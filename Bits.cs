
namespace ConsoleApp1
{
    internal interface IBitGetable
    {
        bool GetBitByIndex(byte index);
        void SetBitByIndex(byte index, bool value);
    }

    internal class Bits : IBitGetable
    {
        public byte Value { get; private set; }
        public Bits(double value)
        {
            Value = value;
        }

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }

        public static implicit operator byte(Bits bits) => bits.Value;
        public static explicit operator Bits(byte value) => new(value);

        public static implicit operator long(Bits bits) => bits.Value;
        public static explicit operator Bits(long value) => new(value);

        public static implicit operator int(Bits bits) => bits.Value;
        public static explicit operator Bits(int value) => new(value);
    }

}

    

