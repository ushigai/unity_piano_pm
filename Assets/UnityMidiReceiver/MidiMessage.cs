// MIDI message struct.
public struct MidiMessage
{
    // MIDI source (endpoint) ID.
    public uint source;

    // MIDI status byte.
    public byte status;

    // MIDI data bytes.
    public byte data1;
    public byte data2;

    public MidiMessage (ulong data)
    {
        source = (uint)(data & 0xffffffffUL);
        status = (byte)((data >> 32) & 0xff);
        data1 = (byte)((data >> 40) & 0xff);
        data2 = (byte)((data >> 48) & 0xff);
    }

    public override string ToString ()
    {
        return string.Format ("s({0:D2}) d({1:D2},{2:D2}) from {3:D8}", status, data1, data2, source);
    }
}