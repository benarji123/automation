///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SWA_1_6_5_Release_Specific_Test_cases.CommonFlows
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Installation recording.
    /// </summary>
    [TestModule("1c6ecfc6-b778-4e1f-b33c-13139900aff7", ModuleType.Recording, 1)]
    public partial class Installation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SWA_1_6_5_Release_Specific_Test_cases.SWA_1_6_5_Release_Specific_Test_casesRepository repository.
        /// </summary>
        public static SWA_1_6_5_Release_Specific_Test_cases.SWA_1_6_5_Release_Specific_Test_casesRepository repo = SWA_1_6_5_Release_Specific_Test_cases.SWA_1_6_5_Release_Specific_Test_casesRepository.Instance;

        static Installation instance = new Installation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Installation()
        {
            AppPath = "C:\\last_build\\IderaSQLwaInstallationKit.1.6.5.x64.exe";
            ServerUsernam = "simpsons\\administrator";
            SQLServerpassword = "control{LShiftKey down}*{LShiftKey up}88";
            RepoInstance = "AUT-SQLDM-004";
            Url = "https://localhost:9291/login";
            Username = "simpsons\\administrator";
            Password = "control*88";
            MSName = "WIN16X64-01\\SQL2017";
            MSUsername = "sa";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Installation Instance
        {
            get { return instance; }
        }

#region Variables

        string _AppPath;

        /// <summary>
        /// Gets or sets the value of variable AppPath.
        /// </summary>
        [TestVariable("a6146d0b-f3f2-476b-a18f-212175b74090")]
        public string AppPath
        {
            get { return _AppPath; }
            set { _AppPath = value; }
        }

        string _ServerUsernam;

        /// <summary>
        /// Gets or sets the value of variable ServerUsernam.
        /// </summary>
        [TestVariable("24ac6b73-d9a2-44eb-ab02-ce5c35cb608c")]
        public string ServerUsernam
        {
            get { return _ServerUsernam; }
            set { _ServerUsernam = value; }
        }

        string _SQLServerpassword;

        /// <summary>
        /// Gets or sets the value of variable SQLServerpassword.
        /// </summary>
        [TestVariable("07f407e4-6a03-44a7-8211-3e3cf277c6f7")]
        public string SQLServerpassword
        {
            get { return _SQLServerpassword; }
            set { _SQLServerpassword = value; }
        }

        string _RepoInstance;

        /// <summary>
        /// Gets or sets the value of variable RepoInstance.
        /// </summary>
        [TestVariable("80b9c43f-584f-4f8d-b2b2-992d86bbf4c5")]
        public string RepoInstance
        {
            get { return _RepoInstance; }
            set { _RepoInstance = value; }
        }

        string _Url;

        /// <summary>
        /// Gets or sets the value of variable Url.
        /// </summary>
        [TestVariable("40ae4eda-c05f-4e4a-9a83-4d26dbb6acea")]
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("3f7e3b7e-80f1-4666-8e98-10228ef1c28f")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("142d63d8-d919-452c-942c-339c737b5315")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        string _MSUsername;

        /// <summary>
        /// Gets or sets the value of variable MSUsername.
        /// </summary>
        [TestVariable("c34b9cd5-a111-46ba-a489-f5d3a99773bc")]
        public string MSUsername
        {
            get { return _MSUsername; }
            set { _MSUsername = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MSName.
        /// </summary>
        [TestVariable("f483fbd8-0c47-4bed-8167-228d78ff031b")]
        public string MSName
        {
            get { return repo.MSName; }
            set { repo.MSName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $AppPath with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(AppPath, "", "C:\\last_build", false);
            
            Report.Log(ReportLevel.Info, "User", AppPath, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'IderaSQLWAV165458'", repo.IderaSQLWAV165458.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.IderaSQLWAV165458.SelfInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'IderaSQLWAV165458.ButtonYes' at 16;8.", repo.IderaSQLWAV165458.ButtonYesInfo, new RecordItemIndex(3));
            repo.IderaSQLWAV165458.ButtonYes.MoveTo("16;8");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'IderaSQLWAV165458.ButtonYes' at 29;12.", repo.IderaSQLWAV165458.ButtonYesInfo, new RecordItemIndex(4));
            repo.IderaSQLWAV165458.ButtonYes.MoveTo("29;12");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Introduction'", repo.Introduction.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.Introduction.SelfInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus('10000ms') on item 'Introduction.Button1'.", repo.Introduction.Button1Info, new RecordItemIndex(6));
            repo.Introduction.Button1.Element.InvokeActionWithText("Focus", "10000ms");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'Introduction.Button1'.", repo.Introduction.Button1Info, new RecordItemIndex(7));
            repo.Introduction.Button1.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'EULA'", repo.EULA.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(8));
            repo.EULA.SelfInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus('10000ms') on item 'EULA.CheckBoxAccept'.", repo.EULA.CheckBoxAcceptInfo, new RecordItemIndex(9));
            repo.EULA.CheckBoxAccept.Element.InvokeActionWithText("Focus", "10000ms");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Check() on item 'EULA.CheckBoxAccept'.", repo.EULA.CheckBoxAcceptInfo, new RecordItemIndex(10));
            repo.EULA.CheckBoxAccept.Check();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(11));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'EULA.ButtonNext'.", repo.EULA.ButtonNextInfo, new RecordItemIndex(12));
            repo.EULA.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(13));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'InstallOption'", repo.InstallOption.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(14));
            repo.InstallOption.SelfInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'InstallOption.ButtonNext'.", repo.InstallOption.ButtonNextInfo, new RecordItemIndex(15));
            repo.InstallOption.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(16));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Credentials'", repo.Credentials.SelfInfo, new ActionTimeout(10000), new RecordItemIndex(17));
            repo.Credentials.SelfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Activate() on item 'Credentials'.", repo.Credentials.SelfInfo, new RecordItemIndex(18));
            repo.Credentials.Self.Activate();
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'Credentials.ButtonNext'.", repo.Credentials.ButtonNextInfo, new RecordItemIndex(19));
            repo.Credentials.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'Description'", repo.Description.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(20));
            repo.Description.SelfInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'Description.Text'.", repo.Description.TextInfo, new RecordItemIndex(21));
            repo.Description.Text.Focus();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'SQLWA' with focus on 'Description.Text'.", repo.Description.TextInfo, new RecordItemIndex(22));
            repo.Description.Text.PressKeys("SQLWA");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'Description.ButtonNext'.", repo.Description.ButtonNextInfo, new RecordItemIndex(23));
            repo.Description.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(24));
            Delay.Duration(500, false);
            
            // Clicks Yes button if  Path not exists
            pathnotexists();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ServiceAccount'", repo.ServiceAccount.SelfInfo, new ActionTimeout(10000), new RecordItemIndex(26));
            repo.ServiceAccount.SelfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ServerUsernam' with focus on 'ServiceAccount.Text'.", repo.ServiceAccount.TextInfo, new RecordItemIndex(27));
            repo.ServiceAccount.Text.PressKeys(ServerUsernam);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(28));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(29));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'ServiceAccount.Text1'.", repo.ServiceAccount.Text1Info, new RecordItemIndex(30));
            repo.ServiceAccount.Text1.Focus();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SQLServerpassword' with focus on 'ServiceAccount.Text1'.", repo.ServiceAccount.Text1Info, new RecordItemIndex(31));
            repo.ServiceAccount.Text1.PressKeys(SQLServerpassword);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(32));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'ServiceAccount.ButtonNext'.", repo.ServiceAccount.ButtonNextInfo, new RecordItemIndex(33));
            repo.ServiceAccount.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SWAPorts'", repo.SWAPorts.SelfInfo, new ActionTimeout(10000), new RecordItemIndex(34));
            repo.SWAPorts.SelfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'SWAPorts.ButtonNext'.", repo.SWAPorts.ButtonNextInfo, new RecordItemIndex(35));
            repo.SWAPorts.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'RepositoryDetails'", repo.RepositoryDetails.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(36));
            repo.RepositoryDetails.SelfInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RepoInstance' with focus on 'RepositoryDetails.Text'.", repo.RepositoryDetails.TextInfo, new RecordItemIndex(37));
            repo.RepositoryDetails.Text.PressKeys(RepoInstance);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'RepositoryDetails.ButtonNext'.", repo.RepositoryDetails.ButtonNextInfo, new RecordItemIndex(38));
            repo.RepositoryDetails.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(39));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DataFileConfiguration'", repo.DataFileConfiguration.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(40));
            repo.DataFileConfiguration.SelfInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'DataFileConfiguration.ButtonNext'.", repo.DataFileConfiguration.ButtonNextInfo, new RecordItemIndex(41));
            repo.DataFileConfiguration.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SWAPorts1'", repo.SWAPorts1.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(42));
            repo.SWAPorts1.SelfInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20700') on item 'SWAPorts1.IDERAFrameworkServicePort'.", repo.SWAPorts1.IDERAFrameworkServicePortInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.SWAPorts1.IDERAFrameworkServicePortInfo, "Text", "20700");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20701') on item 'SWAPorts1.Text'.", repo.SWAPorts1.TextInfo, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.SWAPorts1.TextInfo, "Text", "20701");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20705') on item 'SWAPorts1.ActiveMqMessageQueuePort'.", repo.SWAPorts1.ActiveMqMessageQueuePortInfo, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.SWAPorts1.ActiveMqMessageQueuePortInfo, "Text", "20705");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'SWAPorts1.ButtonNext'.", repo.SWAPorts1.ButtonNextInfo, new RecordItemIndex(46));
            repo.SWAPorts1.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'InstallReady'", repo.InstallReady.SelfInfo, new ActionTimeout(10000), new RecordItemIndex(47));
            repo.InstallReady.SelfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Ready to install IDERA SQL Workload Analysis') on item 'InstallReady.LabelHeading'.", repo.InstallReady.LabelHeadingInfo, new RecordItemIndex(48));
            Validate.AttributeEqual(repo.InstallReady.LabelHeadingInfo, "Text", "Ready to install IDERA SQL Workload Analysis");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'InstallReady.ButtonNext'.", repo.InstallReady.ButtonNextInfo, new RecordItemIndex(49));
            repo.InstallReady.ButtonNext.Press();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'IderaDashboard1'", repo.IderaDashboard1.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(50));
            repo.IderaDashboard1.SelfInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'IderaDashboard1.IderaDashboard'.", repo.IderaDashboard1.IderaDashboardInfo, new RecordItemIndex(51));
            Validate.Exists(repo.IderaDashboard1.IderaDashboardInfo);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'InstallScreen'", repo.InstallScreen.SelfInfo, new ActionTimeout(300000), new RecordItemIndex(52));
            //repo.InstallScreen.SelfInfo.WaitForExists(300000);
            
            installationComplete();
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'InstallScreen.ButtonFinish'.", repo.InstallScreen.ButtonFinishInfo, new RecordItemIndex(54));
            //repo.InstallScreen.ButtonFinish.Press();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(55));
            Delay.Duration(30000, false);
            
            CommonUtilities.SWAWebCommon.Login(Url, Username, Password);
            
            CommonUtilities.SWAWebCommon.NavigatetoDashboard();
            
            // Method to add  Monitored instance
            Addinstance(MSUsername, Password, MSName);
            
            CommonUtilities.SWAWebCommon.Logout();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(60));
            Delay.Duration(30000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
