namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CEndMoviePacket : Packet
    {
        const string Name = "C_END_MOVIE";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CEndMoviePacket();
        }

        [PacketField]
        public uint MovieId { get; set; }

        [PacketField]
        public byte Unknown1 { get; set; }
    }
}
