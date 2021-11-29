using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using Unity.AutomatedQA;
using Unity.CloudTesting;

namespace GeneratedAutomationTests
{
    /// <summary>
    /// These tests were generated by Unity Automated QA for the recording from the Assets folder at "/Recordings/hatoya.json".
    /// You can regenerate this file from the Unity Editor Menu: Automated QA > Generate Recorded Tests
    /// </summary>
    public class Tests_hatoya_full_use_simplified_driver_code : AutomatedQATestsBase
    {
        /// Generated from recording file: "/Recordings/hatoya.json".
        [UnityTest]
        [CloudTest]
        public IEnumerator CanPlayToEnd()
        {
            yield return Driver.Perform.Click(Scene_Keypad_PageObject.Clickable_Keypad_Button_4);
            yield return Driver.Perform.Click(Scene_Keypad_PageObject.Clickable_Keypad_Button_1);
            yield return Driver.Perform.Click(Scene_Keypad_PageObject.Clickable_Keypad_Button_2);
            yield return Driver.Perform.Click(Scene_Keypad_PageObject.Clickable_Keypad_Button_6);
        }
        // Initialize test run data.
        protected override void SetUpTestRun()
        {
            Test.entryScene = Scene_Keypad_PageObject.SceneName;
            Test.recordedAspectRatio = new Vector2(902f,1910f);
            Test.recordedResolution = new Vector2(6016f,3384f);
        }

    }
}

