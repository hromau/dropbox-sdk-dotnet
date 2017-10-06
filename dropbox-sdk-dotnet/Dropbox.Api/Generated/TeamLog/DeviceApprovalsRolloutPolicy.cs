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
    /// <para>The device approvals rollout policy object</para>
    /// </summary>
    public class DeviceApprovalsRolloutPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceApprovalsRolloutPolicy> Encoder = new DeviceApprovalsRolloutPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceApprovalsRolloutPolicy> Decoder = new DeviceApprovalsRolloutPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceApprovalsRolloutPolicy" />
        /// class.</para>
        /// </summary>
        public DeviceApprovalsRolloutPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RemoveOldest</para>
        /// </summary>
        public bool IsRemoveOldest
        {
            get
            {
                return this is RemoveOldest;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RemoveOldest, or <c>null</c>.</para>
        /// </summary>
        public RemoveOldest AsRemoveOldest
        {
            get
            {
                return this as RemoveOldest;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RemoveAll</para>
        /// </summary>
        public bool IsRemoveAll
        {
            get
            {
                return this is RemoveAll;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RemoveAll, or <c>null</c>.</para>
        /// </summary>
        public RemoveAll AsRemoveAll
        {
            get
            {
                return this as RemoveAll;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AddException</para>
        /// </summary>
        public bool IsAddException
        {
            get
            {
                return this is AddException;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AddException, or <c>null</c>.</para>
        /// </summary>
        public AddException AsAddException
        {
            get
            {
                return this as AddException;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceApprovalsRolloutPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsRolloutPolicyEncoder : enc.StructEncoder<DeviceApprovalsRolloutPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceApprovalsRolloutPolicy value, enc.IJsonWriter writer)
            {
                if (value is RemoveOldest)
                {
                    WriteProperty(".tag", "remove_oldest", writer, enc.StringEncoder.Instance);
                    RemoveOldest.Encoder.EncodeFields((RemoveOldest)value, writer);
                    return;
                }
                if (value is RemoveAll)
                {
                    WriteProperty(".tag", "remove_all", writer, enc.StringEncoder.Instance);
                    RemoveAll.Encoder.EncodeFields((RemoveAll)value, writer);
                    return;
                }
                if (value is AddException)
                {
                    WriteProperty(".tag", "add_exception", writer, enc.StringEncoder.Instance);
                    AddException.Encoder.EncodeFields((AddException)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceApprovalsRolloutPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsRolloutPolicyDecoder : enc.UnionDecoder<DeviceApprovalsRolloutPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceApprovalsRolloutPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceApprovalsRolloutPolicy Create()
            {
                return new DeviceApprovalsRolloutPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeviceApprovalsRolloutPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "remove_oldest":
                        return RemoveOldest.Decoder.DecodeFields(reader);
                    case "remove_all":
                        return RemoveAll.Decoder.DecodeFields(reader);
                    case "add_exception":
                        return AddException.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The remove oldest object</para>
        /// </summary>
        public sealed class RemoveOldest : DeviceApprovalsRolloutPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RemoveOldest> Encoder = new RemoveOldestEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RemoveOldest> Decoder = new RemoveOldestDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RemoveOldest" />
            /// class.</para>
            /// </summary>
            private RemoveOldest()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RemoveOldest</para>
            /// </summary>
            public static readonly RemoveOldest Instance = new RemoveOldest();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RemoveOldest" />.</para>
            /// </summary>
            private class RemoveOldestEncoder : enc.StructEncoder<RemoveOldest>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RemoveOldest value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RemoveOldest" />.</para>
            /// </summary>
            private class RemoveOldestDecoder : enc.StructDecoder<RemoveOldest>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RemoveOldest" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RemoveOldest Create()
                {
                    return RemoveOldest.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The remove all object</para>
        /// </summary>
        public sealed class RemoveAll : DeviceApprovalsRolloutPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RemoveAll> Encoder = new RemoveAllEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RemoveAll> Decoder = new RemoveAllDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RemoveAll" /> class.</para>
            /// </summary>
            private RemoveAll()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RemoveAll</para>
            /// </summary>
            public static readonly RemoveAll Instance = new RemoveAll();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RemoveAll" />.</para>
            /// </summary>
            private class RemoveAllEncoder : enc.StructEncoder<RemoveAll>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RemoveAll value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RemoveAll" />.</para>
            /// </summary>
            private class RemoveAllDecoder : enc.StructDecoder<RemoveAll>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RemoveAll" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RemoveAll Create()
                {
                    return RemoveAll.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The add exception object</para>
        /// </summary>
        public sealed class AddException : DeviceApprovalsRolloutPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AddException> Encoder = new AddExceptionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AddException> Decoder = new AddExceptionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AddException" />
            /// class.</para>
            /// </summary>
            private AddException()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AddException</para>
            /// </summary>
            public static readonly AddException Instance = new AddException();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AddException" />.</para>
            /// </summary>
            private class AddExceptionEncoder : enc.StructEncoder<AddException>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AddException value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AddException" />.</para>
            /// </summary>
            private class AddExceptionDecoder : enc.StructDecoder<AddException>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AddException" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AddException Create()
                {
                    return AddException.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeviceApprovalsRolloutPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}