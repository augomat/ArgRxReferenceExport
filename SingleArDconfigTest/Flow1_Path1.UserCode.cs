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
    public partial class Flow1_Path1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Path1Usermethod()
        {
        	TestReport.BeginTestCase("Flow1_Path1");
        	
        	try {
        		TestReport.BeginTestModule("Flow1_Path1_Block1");
	        	Report.Info("Flow1 Path Block1 (only block)");
	        	
	        	Validate.IsTrue(true);
	        	
	        	TestReport.EndTestModule();
        	}
			catch (Exception e) {
        		RanorexCoreReflectionHelper.HandleError(e);
        		TestReport.SaveLocalScreenshotBuffer();
        	}
        	finally {
        		TestReport.EndTestModule();
        		TestReport.BeginTestCaseTeardown();
        		
        		TestReport.BeginTestModule("Flow1_Path1_Teardown");
        		Report.Info("There goes the Teardown");
        		TestReport.EndTestModule();
        		
        		TestReport.EndTestCaseTeardown();
        		
        		TestReport.EndTestCase();	
        	}	
        }

    }
}
