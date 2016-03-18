namespace Rainmeter
{
    public class Version
    {
#if X64
        public const string Informational = "3.3.1.2602 (64-bit^)";
#else
        public const string Informational = "3.3.1.2602 (32-bit^)";
#endif
    }
}
