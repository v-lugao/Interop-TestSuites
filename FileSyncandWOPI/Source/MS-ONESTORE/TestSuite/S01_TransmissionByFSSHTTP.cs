﻿namespace Microsoft.Protocols.TestSuites.MS_ONESTORE
{
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharedAdapter;

    /// <summary>
    /// This scenario is designed to test the requirements related with MS-ONESTORE.
    /// </summary>
    [TestClass]
    public class S01_TransmissionByFSSHTTP : TestSuiteBase
    {
        /// <summary>
        /// Initialize the class.
        /// </summary>
        /// <param name="testContext">VSTS test context.</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            TestSuiteBase.Initialize(testContext);
        }

        /// <summary>
        /// Clear the class.
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            TestSuiteBase.Cleanup();
        }

        #region Test Cases
        /// <summary>
        /// The test case is validate that call QueryChange to get the specific OneNote file.
        /// </summary>
        [TestCategory("MSONESTORE"), TestMethod]
        public void MSONESTORE_S01_TC01_QueryChange_OneNote()
        {
            string url = Common.GetConfigurationPropertyValue("OneNoteFile", Site);
            this.InitializeContext(url, this.UserName, this.Password, this.Domain);
            CellSubRequestType cellSubRequest = this.CreateCellSubRequestEmbeddedQueryChanges(SequenceNumberGenerator.GetCurrentSerialNumber());
            CellStorageResponse cellStorageResponse = this.Adapter.CellStorageRequest(url, new SubRequestType[] { cellSubRequest });
        }

        #endregion Test Cases
    }
}
