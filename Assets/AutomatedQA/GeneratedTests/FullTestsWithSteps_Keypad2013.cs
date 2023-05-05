using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Unity.AutomatedQA;
using Unity.CloudTesting;
using UnityEngine.UI;

namespace GeneratedAutomationTests
{
    /// <summary>
    /// These tests were generated by Unity Automated QA for the recording from the Assets folder at "/Recordings/Keypad2013.json".
    /// You can regenerate this file from the Unity Editor Menu: Automated QA > Generate Recorded Tests
    /// </summary>
    [Category("IgnoreCI")]
    public class FullTestsWithSteps_Keypad2013 : AutomatedQATestsBase
    {
        /// Generated from recording file: "/Recordings/Keypad2013.json".
        [UnityTest]
        [CloudTest]
        public IEnumerator CanPlayToEnd()
        {
            // @formatter:off
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["PRESS_Button2"]); // Do a "press" action on "KeypadCanvas/Button2"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["RELEASE_Button2"]); // Do a "release" action on "KeypadCanvas/Button2"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["PRESS_Button0"]); // Do a "press" action on "KeypadCanvas/Button0"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["RELEASE_Button0"]); // Do a "release" action on "KeypadCanvas/Button0"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["PRESS_Button1"]); // Do a "press" action on "KeypadCanvas/Button1"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["RELEASE_Button1"]); // Do a "release" action on "KeypadCanvas/Button1"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["PRESS_Button3"]); // Do a "press" action on "KeypadCanvas/Button3"in scene "Keypad".
            yield return Driver.Perform.Action(Steps_Keypad2013.Actions["RELEASE_Button3"]); // Do a "release" action on "KeypadCanvas/Button3"in scene "Keypad".
            // @formatter:on

            // Wait 2 frames for the object to be updated (when uses steps file)
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();

            // Verify
            var historyText = Object.FindObjectsOfType<Text>().FirstOrDefault(x => x.name.Equals("HistoryText"));
            Assert.That(historyText, Is.Not.Null);
            Assert.That(historyText.text, Is.EqualTo("2013"));
        }

        // Initialize test run data.
        protected override void SetUpTestRun()
        {
            Test.entryScene = "Keypad";
            Test.recordedAspectRatio = new Vector2(770f, 1626f);
            Test.recordedResolution = new Vector2(6016f, 3384f);
        }

        // Steps defined by recording.
        protected override void SetUpTestClass()
        {
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["PRESS_Button2"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["RELEASE_Button2"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["PRESS_Button0"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["RELEASE_Button0"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["PRESS_Button1"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["RELEASE_Button1"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["PRESS_Button3"]);
            Driver.Perform.RegisterStep(Steps_Keypad2013.Actions["RELEASE_Button3"]);
        }
    }
}
