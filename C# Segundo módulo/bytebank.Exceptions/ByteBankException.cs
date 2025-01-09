using System.Runtime.Serialization;

[Serializable]
internal class ByteBankException : Exception
{
		public ByteBankException() { }
		public ByteBankException(string message) : base("Aconteceu uma exceção ->" + message) { }
		public ByteBankException(string message, Exception inner) : base(message, inner) { }
		protected ByteBankException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}