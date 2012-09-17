// Copyright (c) 2012, Event Store LLP
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
// 
// Redistributions of source code must retain the above copyright notice,
// this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright
// notice, this list of conditions and the following disclaimer in the
// documentation and/or other materials provided with the distribution.
// Neither the name of the Event Store LLP nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 

using System;
using System.Linq;
using EventStore.Core.Messages;
using EventStore.Core.Tests.Bus.Helpers;
using EventStore.Core.Tests.Fakes;
using EventStore.Projections.Core.Messages;
using EventStore.Projections.Core.Services.Processing;
using NUnit.Framework;

namespace EventStore.Projections.Core.Tests.Services.core_projection.emitted_stream
{
    [TestFixture]
    public class when_checkpoint_requested_with_pending_writes
    {
        private EmittedStream _stream;
        private FakePublisher _publisher;
        private TestMessageHandler<ProjectionMessage.Projections.ReadyForCheckpoint> _readyHandler;

        [SetUp]
        public void setup()
        {
            _publisher = new FakePublisher();
            _readyHandler = new TestMessageHandler<ProjectionMessage.Projections.ReadyForCheckpoint>();
            _stream = new EmittedStream("test", _publisher, _readyHandler, false, 50);
            _stream.Start();
            _stream.EmitEvents(
                new[] {new EmittedEvent("stream", Guid.NewGuid(), "type", "data")}, CheckpointTag.FromPosition(-1, -1));
            _stream.Checkpoint();
        }

        [Test]
        public void does_not_publish_ready_for_checkpoint_immediately()
        {
            Assert.AreEqual(0, _publisher.Messages.OfType<ProjectionMessage.Projections.ReadyForCheckpoint>().Count());
        }

        [Test]
        public void publishes_ready_for_checkpoint_on_handling_last_write_events_completed()
        {
            var msg = _publisher.Messages.OfType<ClientMessage.WriteEvents>().First();
            _stream.Handle(new ClientMessage.WriteEventsCompleted(msg.CorrelationId, msg.EventStreamId, 0));
            Assert.AreEqual(
                1, _readyHandler.HandledMessages.OfType<ProjectionMessage.Projections.ReadyForCheckpoint>().Count());
        }
    }
}