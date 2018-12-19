﻿namespace Microsoft.Protocols.TestSuites.MS_ONESTORE
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is used to represent the FileDataStoreListReferenceFND structure.
    /// </summary>
    public class FileDataStoreListReferenceFND : FileNodeBase
    {
        /// <summary>
        /// The format of stp field.
        /// </summary>
        private uint stpFormat;
        /// <summary>
        /// The format of cb field.
        /// </summary>
        private uint cbFormat;

        public FileDataStoreListReferenceFND(uint stpFormat, uint cbFormat)
        {
            this.stpFormat = stpFormat;
            this.cbFormat = cbFormat;
        }

        /// <summary>
        /// Gets or sets the value of the ref field.
        /// </summary>
        public FileNodeChunkReference Ref { get; set; }

        /// <summary>
        /// This method is used to deserialize the FileDataStoreListReferenceFND object from the specified byte array and start index.
        /// </summary>
        /// <param name="byteArray">Specify the byte array.</param>
        /// <param name="startIndex">Specify the start index from the byte array.</param>
        /// <returns>Return the length in byte of the FileDataStoreListReferenceFND object.</returns>
        public override int DoDeserializeFromByteArray(byte[] byteArray, int startIndex)
        {
            this.Ref = new FileNodeChunkReference(this.stpFormat, this.cbFormat);

            return this.Ref.DoDeserializeFromByteArray(byteArray, startIndex);
        }

        /// <summary>
        /// This method is used to convert the element of FileDataStoreListReferenceFND object into a byte List.
        /// </summary>
        /// <returns>Return the byte list which store the byte information of FileDataStoreListReferenceFND.</returns>
        public override List<byte> SerializeToByteList()
        {
            return this.Ref.SerializeToByteList();
        }
    }
}
