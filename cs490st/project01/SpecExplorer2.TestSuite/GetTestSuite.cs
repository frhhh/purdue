//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedTests {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GetTestSuite : VsTestClassBase {
        
        public GetTestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void GetTestSuiteS0() {
            this.Manager.BeginTest("GetTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call checker(INIT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(((TFTPClientNameSpace.TFTPClient.FSM_Modes)(0)));
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call initialize()\'");
            SpecExplorer2.TFTPClientAdapter.initialize();
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("checking step \'return initialize\'");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call checker(INIT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(((TFTPClientNameSpace.TFTPClient.FSM_Modes)(0)));
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call sendReadRequest()\'");
            SpecExplorer2.TFTPClientAdapter.sendReadRequest();
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("checking step \'return sendReadRequest\'");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call checker(RRQ_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.RRQ_SENT);
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("executing step \'call receiveDataBlock()\'");
            SpecExplorer2.TFTPClientAdapter.receiveDataBlock();
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("checking step \'return receiveDataBlock\'");
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("executing step \'call checker(DATA_RECEIVED)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.DATA_RECEIVED);
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("executing step \'call sendACK()\'");
            SpecExplorer2.TFTPClientAdapter.sendACK();
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("checking step \'return sendACK\'");
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.Comment("executing step \'call checker(ACK_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.ACK_SENT);
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S36\'");
            this.Manager.Comment("executing step \'call canGetExit(521)\'");
            SpecExplorer2.TFTPClientAdapter.canGetExit(521);
            this.Manager.Comment("reaching state \'S38\'");
            this.Manager.Comment("checking step \'return canGetExit\'");
            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.Comment("executing step \'call checker(ACK_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.ACK_SENT);
            this.Manager.Comment("reaching state \'S42\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S44\'");
            this.Manager.Comment("executing step \'call receiveDataBlock()\'");
            SpecExplorer2.TFTPClientAdapter.receiveDataBlock();
            this.Manager.Comment("reaching state \'S46\'");
            this.Manager.Comment("checking step \'return receiveDataBlock\'");
            this.Manager.Comment("reaching state \'S47\'");
            this.Manager.Comment("executing step \'call checker(DATA_RECEIVED)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.DATA_RECEIVED);
            this.Manager.Comment("reaching state \'S48\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S49\'");
            this.Manager.Comment("executing step \'call sendACK()\'");
            SpecExplorer2.TFTPClientAdapter.sendACK();
            this.Manager.Comment("reaching state \'S50\'");
            this.Manager.Comment("checking step \'return sendACK\'");
            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("executing step \'call checker(ACK_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.ACK_SENT);
            this.Manager.Comment("reaching state \'S52\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S53\'");
            this.Manager.Comment("executing step \'call canGetExit(521)\'");
            SpecExplorer2.TFTPClientAdapter.canGetExit(521);
            this.Manager.Comment("reaching state \'S54\'");
            this.Manager.Comment("checking step \'return canGetExit\'");
            this.Manager.Comment("reaching state \'S55\'");
            this.Manager.Assert(false, "exploration of test code generation hit a path depth bound at state \'S55\'.");
            this.Manager.Assert(false, "reached non-accepting end state \'S55\'.");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void GetTestSuiteS2() {
            this.Manager.BeginTest("GetTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call checker(INIT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(((TFTPClientNameSpace.TFTPClient.FSM_Modes)(0)));
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("executing step \'call initialize()\'");
            SpecExplorer2.TFTPClientAdapter.initialize();
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return initialize\'");
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("executing step \'call checker(INIT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(((TFTPClientNameSpace.TFTPClient.FSM_Modes)(0)));
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("executing step \'call sendReadRequest()\'");
            SpecExplorer2.TFTPClientAdapter.sendReadRequest();
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return sendReadRequest\'");
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("executing step \'call checker(RRQ_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.RRQ_SENT);
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call receiveDataBlock()\'");
            SpecExplorer2.TFTPClientAdapter.receiveDataBlock();
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("checking step \'return receiveDataBlock\'");
            this.Manager.Comment("reaching state \'S25\'");
            this.Manager.Comment("executing step \'call checker(DATA_RECEIVED)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.DATA_RECEIVED);
            this.Manager.Comment("reaching state \'S27\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("executing step \'call sendACK()\'");
            SpecExplorer2.TFTPClientAdapter.sendACK();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return sendACK\'");
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.Comment("executing step \'call checker(ACK_SENT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(TFTPClientNameSpace.TFTPClient.FSM_Modes.ACK_SENT);
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S37\'");
            this.Manager.Comment("executing step \'call canGetExit(511)\'");
            SpecExplorer2.TFTPClientAdapter.canGetExit(511);
            this.Manager.Comment("reaching state \'S39\'");
            this.Manager.Comment("checking step \'return canGetExit\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call checker(EXIT)\'");
            SpecExplorer2.TFTPClientAdapter.checker(((TFTPClientNameSpace.TFTPClient.FSM_Modes)(1)));
            this.Manager.Comment("reaching state \'S43\'");
            this.Manager.Comment("checking step \'return checker\'");
            this.Manager.Comment("reaching state \'S45\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
