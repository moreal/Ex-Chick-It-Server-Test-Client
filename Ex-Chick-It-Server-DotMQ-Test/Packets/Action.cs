// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: action.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gameplay {

  /// <summary>Holder for reflection information generated from action.proto</summary>
  public static partial class ActionReflection {

    #region Descriptor
    /// <summary>File descriptor for action.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxhY3Rpb24ucHJvdG8SCGdhbWVwbGF5IpgBCgtFdmVudFBhY2tldBISCgpz",
            "ZXNzaW9uX2lkGAEgASgFEi4KBHR5cGUYAiABKA4yIC5nYW1lcGxheS5FdmVu",
            "dFBhY2tldC5BY3Rpb25UeXBlEg4KBnJhZGl1cxgDIAEoAhIRCglzZW5kX3Rp",
            "bWUYBCABKAIiIgoKQWN0aW9uVHlwZRIICgRNT1ZFEAASCgoGQVRUQUNLEAFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Gameplay.EventPacket), global::Gameplay.EventPacket.Parser, new[]{ "SessionId", "Type", "Radius", "SendTime" }, null, new[]{ typeof(global::Gameplay.EventPacket.Types.ActionType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EventPacket : pb::IMessage<EventPacket> {
    private static readonly pb::MessageParser<EventPacket> _parser = new pb::MessageParser<EventPacket>(() => new EventPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EventPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gameplay.ActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventPacket(EventPacket other) : this() {
      sessionId_ = other.sessionId_;
      type_ = other.type_;
      radius_ = other.radius_;
      sendTime_ = other.sendTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventPacket Clone() {
      return new EventPacket(this);
    }

    /// <summary>Field number for the "session_id" field.</summary>
    public const int SessionIdFieldNumber = 1;
    private int sessionId_;
    /// <summary>
    /// identity for who did this event
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SessionId {
      get { return sessionId_; }
      set {
        sessionId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Gameplay.EventPacket.Types.ActionType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Gameplay.EventPacket.Types.ActionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "radius" field.</summary>
    public const int RadiusFieldNumber = 3;
    private float radius_;
    /// <summary>
    /// PlayStatus
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Radius {
      get { return radius_; }
      set {
        radius_ = value;
      }
    }

    /// <summary>Field number for the "send_time" field.</summary>
    public const int SendTimeFieldNumber = 4;
    private float sendTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float SendTime {
      get { return sendTime_; }
      set {
        sendTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EventPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EventPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SessionId != other.SessionId) return false;
      if (Type != other.Type) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Radius, other.Radius)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SendTime, other.SendTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SessionId != 0) hash ^= SessionId.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Radius != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Radius);
      if (SendTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SendTime);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SessionId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SessionId);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Radius != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Radius);
      }
      if (SendTime != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(SendTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SessionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SessionId);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Radius != 0F) {
        size += 1 + 4;
      }
      if (SendTime != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EventPacket other) {
      if (other == null) {
        return;
      }
      if (other.SessionId != 0) {
        SessionId = other.SessionId;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Radius != 0F) {
        Radius = other.Radius;
      }
      if (other.SendTime != 0F) {
        SendTime = other.SendTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            SessionId = input.ReadInt32();
            break;
          }
          case 16: {
            type_ = (global::Gameplay.EventPacket.Types.ActionType) input.ReadEnum();
            break;
          }
          case 29: {
            Radius = input.ReadFloat();
            break;
          }
          case 37: {
            SendTime = input.ReadFloat();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EventPacket message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ActionType {
        [pbr::OriginalName("MOVE")] Move = 0,
        [pbr::OriginalName("ATTACK")] Attack = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code