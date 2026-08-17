namespace SpedHub.Data.Text
{
    public readonly struct MarkdownToken : IEquatable<string>
    {
        public readonly MarkdownTokenType Kind;

        public readonly string Value;

        public MarkdownToken()
        {
            Kind = MarkdownTokenType.None;
            Value = "";
        }

        public MarkdownToken(MarkdownTokenType kind, string value)
        {
            Kind = kind;
            Value = value;
        }

        public override string ToString() => Value;

        public bool Equals(string? other)
            => StringComparer.CurrentCulture.Equals(Value, (other));

        public override bool Equals(object? obj)
            => obj is string other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(MarkdownToken left, MarkdownToken right)
            => left.Equals(right);

        public static bool operator !=(MarkdownToken left, MarkdownToken right)
            => !left.Equals(right);
    }
}
