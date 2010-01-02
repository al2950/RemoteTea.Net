namespace org.acplt.oncrpc
{
	/// <summary>
	/// Instances of the class <code>XdrOpaque</code> represent (de-)serializeable
	/// fixed-size opaque values, which are especially useful in cases where a result with only a
	/// single opaque value is expected from a remote function call or only a single
	/// opaque value parameter needs to be supplied.
	/// </summary>
	/// <remarks>
	/// Instances of the class <code>XdrOpaque</code> represent (de-)serializeable
	/// fixed-size opaque values, which are especially useful in cases where a result with only a
	/// single opaque value is expected from a remote function call or only a single
	/// opaque value parameter needs to be supplied.
	/// <p>Please note that this class is somewhat modelled after Java's primitive
	/// data type wrappers. As for these classes, the XDR data type wrapper classes
	/// follow the concept of values with no identity, so you are not allowed to
	/// change the value after you've created a value object.
	/// </remarks>
	/// <version>$Revision: 1.1.1.1 $ $Date: 2003/08/13 12:03:40 $ $State: Exp $ $Locker:  $
	/// 	</version>
	/// <author>Harald Albrecht</author>
	public class XdrOpaque : org.acplt.oncrpc.XdrAble
	{
		/// <summary>Constructs and initializes a new <code>XdrOpaque</code> object.</summary>
		/// <remarks>Constructs and initializes a new <code>XdrOpaque</code> object.</remarks>
		public XdrOpaque(byte[] value)
		{
			this.value = value;
		}

		/// <summary>
		/// Constructs and initializes a new <code>XdrOpaque</code> object given
		/// only the size of the opaque value.
		/// </summary>
		/// <remarks>
		/// Constructs and initializes a new <code>XdrOpaque</code> object given
		/// only the size of the opaque value.
		/// </remarks>
		/// <param name="length">size of opaque value.</param>
		public XdrOpaque(int length)
		{
			this.value = new byte[length];
		}

		/// <summary>
		/// Returns the value of this <code>XdrOpaque</code> object as a byte
		/// vector.
		/// </summary>
		/// <remarks>
		/// Returns the value of this <code>XdrOpaque</code> object as a byte
		/// vector.
		/// </remarks>
		/// <returns>The primitive <code>byte[]</code> value of this object.</returns>
		public virtual byte[] opaqueValue()
		{
			return this.value;
		}

		/// <summary>
		/// Encodes -- that is: serializes -- a XDR opaque into a XDR stream in
		/// compliance to RFC 1832.
		/// </summary>
		/// <remarks>
		/// Encodes -- that is: serializes -- a XDR opaque into a XDR stream in
		/// compliance to RFC 1832.
		/// </remarks>
		/// <exception cref="OncRpcException">if an ONC/RPC error occurs.</exception>
		/// <exception cref="System.IO.IOException">if an I/O error occurs.</exception>
		/// <exception cref="org.acplt.oncrpc.OncRpcException"></exception>
		public virtual void xdrEncode(org.acplt.oncrpc.XdrEncodingStream xdr)
		{
			xdr.xdrEncodeOpaque(value);
		}

		/// <summary>
		/// Decodes -- that is: deserializes -- a XDR opaque from a XDR stream in
		/// compliance to RFC 1832.
		/// </summary>
		/// <remarks>
		/// Decodes -- that is: deserializes -- a XDR opaque from a XDR stream in
		/// compliance to RFC 1832.
		/// </remarks>
		/// <exception cref="OncRpcException">if an ONC/RPC error occurs.</exception>
		/// <exception cref="System.IO.IOException">if an I/O error occurs.</exception>
		/// <exception cref="org.acplt.oncrpc.OncRpcException"></exception>
		public virtual void xdrDecode(org.acplt.oncrpc.XdrDecodingStream xdr)
		{
			xdr.xdrDecodeOpaque(value);
		}

		/// <summary>The encapsulated opaque value itself.</summary>
		/// <remarks>The encapsulated opaque value itself.</remarks>
		private byte[] value;
	}
}
