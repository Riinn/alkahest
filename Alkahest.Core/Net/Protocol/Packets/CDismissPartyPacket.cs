namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CDismissPartyPacket : Packet
    {
        const string Name = "C_DISMISS_PARTY";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CDismissPartyPacket();
        }
    }
}
