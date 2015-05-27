// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The list folder arg object</para>
    /// </summary>
    public sealed class ListFolderArg : enc.IEncodable<ListFolderArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path</param>
        public ListFolderArg(string path)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFolderArg()
        {
        }

        /// <summary>
        /// <para>Gets the path of the list folder arg</para>
        /// </summary>
        public string Path { get; private set; }

        #region IEncodable<ListFolderArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListFolderArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListFolderArg enc.IEncodable<ListFolderArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");

                return this;
            }
        }

        #endregion
    }
}