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
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SingleArDconfigTest
{
    public partial class Flow1_Path2
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Record2Usercode()
        {
        	TestReport.BeginTestCase("Flow1_Path2");
        	
        	try {
        		TestReport.BeginTestModule("Flow1_Path2_Block1");
        		
	        	Report.Info("Flow1 Path2 Block1 (only block)");
	        	Report.Info("This is it!");
	        	Delay.Milliseconds(200);
	        	Report.Info("This is it!");
	        	Delay.Milliseconds(200);
	        	
	        	var start = repo.Explorer.Start;
	        	start.MoveTo();
	        	
	        	//-------------- copied from NotepadTest
	        	Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\System32\\notepad.exe' with arguments '' in normal mode.");
	            Host.Local.RunApplication("C:\\Windows\\System32\\notepad.exe", "", "C:\\Windows\\System32", false);
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.Text15' at 254;96.", repo.UntitledNotepad.Text15Info);
	            repo.UntitledNotepad.Text15.Click("254;96");
	            
	            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aaa' with focus on 'UntitledNotepad.Text15'.", repo.UntitledNotepad.Text15Info);
	            repo.UntitledNotepad.Text15.PressKeys("aaa");
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.Edit' at 21;17.", repo.UntitledNotepad.EditInfo);
	            repo.UntitledNotepad.Edit.Click("21;17");
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Notepad.UndoCtrlPlusZ' at 35;6.", repo.Notepad.UndoCtrlPlusZInfo);
	            repo.Notepad.UndoCtrlPlusZ.Click("35;6");
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.File' at 5;14.", repo.UntitledNotepad.FileInfo);
	            repo.UntitledNotepad.File.Click("5;14");
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Notepad.Exit' at 34;13.", repo.Notepad.ExitInfo);
	            repo.Notepad.Exit.Click("34;13");
	            //--------------
	        	
	            Validate.IsTrue(false);
	        	
	        	TestReport.EndTestModule();
        	}
			catch (Exception e) {
                    RanorexCoreReflectionHelper.HandleError(e); //TODO return result?!
                    TestReport.SaveLocalScreenshotBuffer();       		
        	}
        	finally {
        		TestReport.EndTestModule();
        		TestReport.BeginTestCaseTeardown();
        		
        		TestReport.BeginTestModule("Flow1_Path2_Teardown");
        		Report.Info("There goes the Teardown");
        		TestReport.EndTestModule();
        		
        		TestReport.EndTestCaseTeardown();
        		
        		TestReport.EndTestCase();	
        	}	
        }
    }
}
