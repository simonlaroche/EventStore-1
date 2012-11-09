//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ClientMessageDtos.proto
using System;
using System.ComponentModel;
using System.Collections.Generic;
using ProtoBuf;

namespace EventStore.Core.Messages
{
  public static partial class TcpClientMessageDto
  {
  [Serializable, ProtoContract(Name=@"EventLinkPair")]
  public partial class EventLinkPair
  {
    [ProtoMember(1, IsRequired = true, Name=@"event", DataFormat = DataFormat.Default)]
    public readonly EventRecord Event;
  
    [ProtoMember(2, IsRequired = true, Name=@"link", DataFormat = DataFormat.Default)]
    public readonly EventRecord Link;
  
    private EventLinkPair() {}
  
    public EventLinkPair(EventRecord @event, EventRecord link)
    {
        Event = @event;
        Link = link;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ClientEvent")]
  public partial class ClientEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_id", DataFormat = DataFormat.Default)]
    public readonly byte[] EventId;
  
    [ProtoMember(2, IsRequired = false, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(3, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(4, IsRequired = false, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    private ClientEvent() {}
  
    public ClientEvent(byte[] eventId, string eventType, byte[] data, byte[] metadata)
    {
        EventId = eventId;
        EventType = eventType;
        Data = data;
        Metadata = metadata;
    }
  }
  
  [Serializable, ProtoContract(Name=@"EventRecord")]
  public partial class EventRecord
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"event_id", DataFormat = DataFormat.Default)]
    public readonly byte[] EventId;
  
    [ProtoMember(4, IsRequired = true, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(5, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(6, IsRequired = true, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    private EventRecord() {}
  
    public EventRecord(string eventStreamId, int eventNumber, byte[] eventId, string eventType, byte[] data, byte[] metadata)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        EventId = eventId;
        EventType = eventType;
        Data = data;
        Metadata = metadata;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeniedToRoute")]
  public partial class DeniedToRoute
  {
    [ProtoMember(1, IsRequired = true, Name=@"external_tcp_address", DataFormat = DataFormat.Default)]
    public readonly string ExternalTcpAddress;
  
    [ProtoMember(2, IsRequired = true, Name=@"external_tcp_port", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExternalTcpPort;
  
    [ProtoMember(3, IsRequired = true, Name=@"external_http_address", DataFormat = DataFormat.Default)]
    public readonly string ExternalHttpAddress;
  
    [ProtoMember(4, IsRequired = true, Name=@"external_http_port", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExternalHttpPort;
  
    private DeniedToRoute() {}
  
    public DeniedToRoute(string externalTcpAddress, int externalTcpPort, string externalHttpAddress, int externalHttpPort)
    {
        ExternalTcpAddress = externalTcpAddress;
        ExternalTcpPort = externalTcpPort;
        ExternalHttpAddress = externalHttpAddress;
        ExternalHttpPort = externalHttpPort;
    }
  }
  
  [Serializable, ProtoContract(Name=@"CreateStream")]
  public partial class CreateStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = false, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private CreateStream() {}
  
    public CreateStream(string eventStreamId, byte[] metadata, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        Metadata = metadata;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"CreateStreamCompleted")]
  public partial class CreateStreamCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(3, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    private CreateStreamCompleted() {}
  
    public CreateStreamCompleted(string eventStreamId, int errorCode, string error)
    {
        EventStreamId = eventStreamId;
        ErrorCode = errorCode;
        Error = error;
    }
  }
  
  [Serializable, ProtoContract(Name=@"WriteEvents")]
  public partial class WriteEvents
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly ClientEvent[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private WriteEvents() {}
  
    public WriteEvents(string eventStreamId, int expectedVersion, ClientEvent[] events, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        Events = events;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"WriteEventsCompleted")]
  public partial class WriteEventsCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(3, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    [ProtoMember(4, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    private WriteEventsCompleted() {}
  
    public WriteEventsCompleted(string eventStreamId, int errorCode, string error, int eventNumber)
    {
        EventStreamId = eventStreamId;
        ErrorCode = errorCode;
        Error = error;
        EventNumber = eventNumber;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeleteStream")]
  public partial class DeleteStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private DeleteStream() {}
  
    public DeleteStream(string eventStreamId, int expectedVersion, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeleteStreamCompleted")]
  public partial class DeleteStreamCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(3, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    private DeleteStreamCompleted() {}
  
    public DeleteStreamCompleted(string eventStreamId, int errorCode, string error)
    {
        EventStreamId = eventStreamId;
        ErrorCode = errorCode;
        Error = error;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadEvent")]
  public partial class ReadEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadEvent() {}
  
    public ReadEvent(string eventStreamId, int eventNumber, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadEventCompleted")]
  public partial class ReadEventCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly int Result;
  
    [ProtoMember(4, IsRequired = true, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(5, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(6, IsRequired = true, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    [ProtoMember(7, IsRequired = true, Name=@"log_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long LogPosition;
  
    private ReadEventCompleted() {}
  
    public ReadEventCompleted(string eventStreamId, int eventNumber, int result, string eventType, byte[] data, byte[] metadata, long logPosition)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        Result = result;
        EventType = eventType;
        Data = data;
        Metadata = metadata;
        LogPosition = logPosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEventsForward")]
  public partial class ReadStreamEventsForward
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"start_index", DataFormat = DataFormat.TwosComplement)]
    public readonly int StartIndex;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadStreamEventsForward() {}
  
    public ReadStreamEventsForward(string eventStreamId, int startIndex, int maxCount, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        StartIndex = startIndex;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEventsForwardCompleted")]
  public partial class ReadStreamEventsForwardCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly EventLinkPair[] Events;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly int Result;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int NextEventNumber;
  
    [ProtoMember(5, IsRequired = true, Name=@"last_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int LastEventNumber;
  
    [ProtoMember(6, IsRequired = true, Name=@"is_end_of_stream", DataFormat = DataFormat.Default)]
    public readonly bool IsEndOfStream;
  
    [ProtoMember(7, IsRequired = false, Name=@"last_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long? LastCommitPosition;
  
    private ReadStreamEventsForwardCompleted() {}
  
    public ReadStreamEventsForwardCompleted(string eventStreamId, EventLinkPair[] events, int result, int nextEventNumber, int lastEventNumber, bool isEndOfStream, long? lastCommitPosition)
    {
        EventStreamId = eventStreamId;
        Events = events;
        Result = result;
        NextEventNumber = nextEventNumber;
        LastEventNumber = lastEventNumber;
        IsEndOfStream = isEndOfStream;
        LastCommitPosition = lastCommitPosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEventsBackward")]
  public partial class ReadStreamEventsBackward
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"start_index", DataFormat = DataFormat.TwosComplement)]
    public readonly int StartIndex;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadStreamEventsBackward() {}
  
    public ReadStreamEventsBackward(string eventStreamId, int startIndex, int maxCount, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        StartIndex = startIndex;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEventsBackwardCompleted")]
  public partial class ReadStreamEventsBackwardCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly EventLinkPair[] Events;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly int Result;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int NextEventNumber;
  
    [ProtoMember(5, IsRequired = true, Name=@"last_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int LastEventNumber;
  
    [ProtoMember(6, IsRequired = true, Name=@"is_end_of_stream", DataFormat = DataFormat.Default)]
    public readonly bool IsEndOfStream;
  
    [ProtoMember(7, IsRequired = false, Name=@"last_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long? LastCommitPosition;
  
    private ReadStreamEventsBackwardCompleted() {}
  
    public ReadStreamEventsBackwardCompleted(string eventStreamId, EventLinkPair[] events, int result, int nextEventNumber, int lastEventNumber, bool isEndOfStream, long? lastCommitPosition)
    {
        EventStreamId = eventStreamId;
        Events = events;
        Result = result;
        NextEventNumber = nextEventNumber;
        LastEventNumber = lastEventNumber;
        IsEndOfStream = isEndOfStream;
        LastCommitPosition = lastCommitPosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEventsForward")]
  public partial class ReadAllEventsForward
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadAllEventsForward() {}
  
    public ReadAllEventsForward(long commitPosition, long preparePosition, int maxCount, bool resolveLinkTos)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEventsForwardCompleted")]
  public partial class ReadAllEventsForwardCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly EventLinkPair[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextCommitPosition;
  
    [ProtoMember(5, IsRequired = true, Name=@"next_prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextPreparePosition;
  
    private ReadAllEventsForwardCompleted() {}
  
    public ReadAllEventsForwardCompleted(long commitPosition, long preparePosition, EventLinkPair[] events, long nextCommitPosition, long nextPreparePosition)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        Events = events;
        NextCommitPosition = nextCommitPosition;
        NextPreparePosition = nextPreparePosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEventsBackward")]
  public partial class ReadAllEventsBackward
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadAllEventsBackward() {}
  
    public ReadAllEventsBackward(long commitPosition, long preparePosition, int maxCount, bool resolveLinkTos)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEventsBackwardCompleted")]
  public partial class ReadAllEventsBackwardCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly EventLinkPair[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextCommitPosition;
  
    [ProtoMember(5, IsRequired = true, Name=@"next_prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextPreparePosition;
  
    private ReadAllEventsBackwardCompleted() {}
  
    public ReadAllEventsBackwardCompleted(long commitPosition, long preparePosition, EventLinkPair[] events, long nextCommitPosition, long nextPreparePosition)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        Events = events;
        NextCommitPosition = nextCommitPosition;
        NextPreparePosition = nextPreparePosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionStart")]
  public partial class TransactionStart
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionStart() {}
  
    public TransactionStart(string eventStreamId, int expectedVersion, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionStartCompleted")]
  public partial class TransactionStartCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(4, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    private TransactionStartCompleted() {}
  
    public TransactionStartCompleted(long transactionId, string eventStreamId, int errorCode, string error)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        ErrorCode = errorCode;
        Error = error;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionWrite")]
  public partial class TransactionWrite
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly ClientEvent[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionWrite() {}
  
    public TransactionWrite(long transactionId, string eventStreamId, ClientEvent[] events, bool allowForwarding)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        Events = events;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionWriteCompleted")]
  public partial class TransactionWriteCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(4, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    private TransactionWriteCompleted() {}
  
    public TransactionWriteCompleted(long transactionId, string eventStreamId, int errorCode, string error)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        ErrorCode = errorCode;
        Error = error;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionCommit")]
  public partial class TransactionCommit
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionCommit() {}
  
    public TransactionCommit(long transactionId, string eventStreamId, bool allowForwarding)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionCommitCompleted")]
  public partial class TransactionCommitCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"error_code", DataFormat = DataFormat.TwosComplement)]
    public readonly int ErrorCode;
  
    [ProtoMember(3, IsRequired = true, Name=@"error", DataFormat = DataFormat.Default)]
    public readonly string Error;
  
    private TransactionCommitCompleted() {}
  
    public TransactionCommitCompleted(long transactionId, int errorCode, string error)
    {
        TransactionId = transactionId;
        ErrorCode = errorCode;
        Error = error;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscribeToStream")]
  public partial class SubscribeToStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    private SubscribeToStream() {}
  
    public SubscribeToStream(string eventStreamId)
    {
        EventStreamId = eventStreamId;
    }
  }
  
  [Serializable, ProtoContract(Name=@"UnsubscribeFromStream")]
  public partial class UnsubscribeFromStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    private UnsubscribeFromStream() {}
  
    public UnsubscribeFromStream(string eventStreamId)
    {
        EventStreamId = eventStreamId;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscribeToAllStreams")]
  public partial class SubscribeToAllStreams
  {
    public SubscribeToAllStreams()
    {
    }
  }
  
  [Serializable, ProtoContract(Name=@"UnsubscribeFromAllStreams")]
  public partial class UnsubscribeFromAllStreams
  {
    public UnsubscribeFromAllStreams()
    {
    }
  }
  
  [Serializable, ProtoContract(Name=@"StreamEventAppeared")]
  public partial class StreamEventAppeared
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"event_id", DataFormat = DataFormat.Default)]
    public readonly byte[] EventId;
  
    [ProtoMember(4, IsRequired = true, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(5, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(6, IsRequired = true, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    [ProtoMember(7, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(8, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    private StreamEventAppeared() {}
  
    public StreamEventAppeared(string eventStreamId, int eventNumber, byte[] eventId, string eventType, byte[] data, byte[] metadata, long commitPosition, long preparePosition)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        EventId = eventId;
        EventType = eventType;
        Data = data;
        Metadata = metadata;
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscriptionDropped")]
  public partial class SubscriptionDropped
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    private SubscriptionDropped() {}
  
    public SubscriptionDropped(string eventStreamId)
    {
        EventStreamId = eventStreamId;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscriptionToAllDropped")]
  public partial class SubscriptionToAllDropped
  {
    public SubscriptionToAllDropped()
    {
    }
  }
  
  }
}