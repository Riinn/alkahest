namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class SPartyMemberChangeHPPacket : Packet
    {
        const string Name = "S_PARTY_MEMBER_CHANGE_HP";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new SPartyMemberChangeHPPacket();
        }

        [PacketField]
        public uint ServerId { get; set; }

        [PacketField]
        public uint PlayerId { get; set; }

        [PacketField]
        public uint CurrentHP { get; set; }

        [PacketField]
        public uint MaxHP { get; set; }
    }
}
