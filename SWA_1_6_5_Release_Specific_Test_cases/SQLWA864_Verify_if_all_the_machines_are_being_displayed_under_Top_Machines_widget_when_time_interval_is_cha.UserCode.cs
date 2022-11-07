﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SWA_1_6_5_Release_Specific_Test_cases
{
    public partial class SQLWA864_Verify_if_all_the_machines_are_being_displayed_under_Top_Machines_widget_when_time_interval_is_cha
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void validateTopMachines(string instancename)
        {
            // TODO: Replace the following line with your code implementation.
//            throw new NotImplementedException();
			int delay=10;			
			Delay.Seconds(delay);
            TdTag serverInstance = "/dom[@domain='localhost:9291']//iframe[1]//table[#'instancesLeftDataTable']/tbody/?/?/td[@innertext='WIN10SQL17']";
			serverInstance.MoveTo();
			serverInstance.Click();
            
            var BA4Qi2 = repo.Https10220201289291Gui460Rende;
            
            //Click on 15M validate
            var timeframeButton15M = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton15M;
            timeframeButton15M.PerformClick();
            Delay.Seconds(delay);

            //Click on 1 H and validate
            var timeframeButton1H = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton1H;
            timeframeButton1H.PerformClick();
            Delay.Seconds(delay);
            
            //Click on 4 H and validate
            var timeframeButton4H = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton4H;
            timeframeButton4H.PerformClick();
            
            Delay.Seconds(delay);
            
             //Click on 1 D and validate
            var timeframeButton1D = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton1D;
            timeframeButton1D.PerformClick();
            
            Delay.Seconds(delay);
            //Click on 5 D and validate
            var timeframeButton5D = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton5D;
            timeframeButton5D.PerformClick();
            
            Delay.Seconds(delay);
             
             //Click on 4 W and validate
             var timeframeButton4W = repo.Https10220201289291Gui460Rende.GI1Wi2.TimeframeButton4W;
             timeframeButton4W.PerformClick();
             
             Delay.Seconds(delay);
        }
        
        public void addNewInstance(String instancename1, String Username1, String Password)
        {
        	var administrationLink = repo.IderaDashboard.AdministrationLink;
        	administrationLink.PerformClick();
        	Delay.Seconds(5);
        	
        	var addSQLServerInstance = repo.Https10220201289291Gui460Rende.W53Xi2.AddSQLServerInstance;
        	addSQLServerInstance.PerformClick();
        	Delay.Seconds(5);
        	
        	var nextButton = repo.Https10220201289291Gui460Rende.W53Xi2.NextButton;
        	nextButton.Focus();
        	Delay.Seconds(2);
        	nextButton.PerformClick();
        	Delay.Seconds(5);
        	
        	var mInstancename = repo.Https10220201289291Gui460Rende.W53Xi2.MInstancename;
        	mInstancename.Focus();
        	Delay.Seconds(2);
        	nextButton.PerformClick();
        	nextButton.PressKeys(instancename1);
        	Delay.Seconds(5);
        	
        	var mConnection = repo.Https10220201289291Gui460Rende.W53Xi2.MConnection;
        	mConnection.Focus();
        	Delay.Seconds(2);
        	
        	var mSqluser = repo.Https10220201289291Gui460Rende.W53Xi2.MSqluser;
        	mSqluser.Focus();
        	Delay.Seconds(2);
        	mSqluser.PressKeys(Username1);
        	Delay.Seconds(3);
        	
        	var mSqlpassword = repo.Https10220201289291Gui460Rende.W53Xi2.MSqlpassword;
        	mSqlpassword.Focus();
        	Delay.Seconds(2);
        	mSqluser.PressKeys(Password);
        	Delay.Seconds(3);

        	var nextButton1 = repo.Https10220201289291Gui460Rende.W53Xi2.NextButton;
        	nextButton1.Focus();
        	Delay.Seconds(2);
        	nextButton1.PerformClick();
        	Delay.Seconds(10);

        	var nextButton11 = repo.Https10220201289291Gui460Rende.NextButton1;
        	nextButton11.Focus();
        	Delay.Seconds(2);
        	nextButton11.PerformClick();
        	Delay.Seconds(10);
        
        }
        
        /// <summary>
        /// The method is used to removing the servers which are added and verify if the machines are also removed from 'Top Machines' widget.
        /// </summary>
        public void removeInstance(String instancename1)
        {
        	var administrationLink = repo.IderaDashboard.AdministrationLink;
        	
        	administrationLink.PerformClick();
        	Delay.Seconds(5);
        	
        	var manageSQLServerInstances = repo.IderaDashboard.ManageSQLServerInstances;
        	Delay.Seconds(2);
        	
        	manageSQLServerInstances.PerformClick();
        	Delay.Seconds(5);
        	
        	var dEVRAHUL001 = repo.Https10220201289291Gui460Rende.ManageInstance.DEVRAHUL001;

			var BA4Qi2 = repo.Https10220201289291Gui460Rende.ManageInstance;
			Validate.AttributeEqual(BA4Qi2.DEVRAHUL001Info,"InnerText",instancename1);
			try
			{
				var checkbox = repo.Https10220201289291Gui460Rende.ManageInstance.Checkbox;
        		checkbox.PerformClick();
        		Delay.Seconds(2);
        		
        		var httpsDevRahul0019291GuiSqlwaRed = repo.Https10220201289291Gui460Rende.ManageInstance.HttpsDevRahul0019291GuiSqlwaRed;
        		httpsDevRahul0019291GuiSqlwaRed.PerformClick();
        		Delay.Seconds(2);
        		
        		var removeInstance = repo.Https10220201289291Gui460Rende.ManageInstance.RemoveInstance;
        		removeInstance.PerformClick();
        		Delay.Seconds(2);
        		
        		var removeInstancebtn = repo.Https10220201289291Gui460Rende.RemoveInstancebtn;
        		removeInstancebtn.PerformClick();
        		Delay.Seconds(2);
        		
        		var button = repo.Https10220201289291Gui460Rende.Button;
        		button.PerformClick();
        		Delay.Seconds(5);

        	}
        	finally{
        		Report.Log(ReportLevel.Info,"Added Instance is not same as expected instance.");
        	}
        }

    }
}