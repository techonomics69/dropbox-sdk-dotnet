// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The sso remove cert type object</para>
    /// </summary>
    public class SsoRemoveCertType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoRemoveCertType> Encoder = new SsoRemoveCertTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoRemoveCertType> Decoder = new SsoRemoveCertTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoRemoveCertType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SsoRemoveCertType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoRemoveCertType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoRemoveCertType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the sso remove cert type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoRemoveCertType" />.</para>
        /// </summary>
        private class SsoRemoveCertTypeEncoder : enc.StructEncoder<SsoRemoveCertType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoRemoveCertType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoRemoveCertType" />.</para>
        /// </summary>
        private class SsoRemoveCertTypeDecoder : enc.StructDecoder<SsoRemoveCertType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoRemoveCertType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoRemoveCertType Create()
            {
                return new SsoRemoveCertType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoRemoveCertType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
