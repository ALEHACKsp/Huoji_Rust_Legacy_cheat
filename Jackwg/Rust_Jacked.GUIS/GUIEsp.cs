using Rust_Jacked.Hacks;
using Rust_Jacked.Settings;
using System;
using UnityEngine;
namespace Rust_Jacked.GUIS
{
	internal class GUIEsp : MonoBehaviour
	{
		public static Rect startRect = new Rect(100f, 150f, 140f, 150f);
		private void Start()
		{
			GUIEsp.startRect.x = GUIAimbot.startRect.xMax + 25f;
		}
		private void OnGUI()
		{
            if (HackLocal.ShowMenu)
			{
				GUIEsp.startRect = GUI.Window(3, GUIEsp.startRect, new GUI.WindowFunction(this.DoMyWindow), "͸��");
			}
		}
		private void DoMyWindow(int windowID)
		{
			CVars.ESP.DrawPlayers = GUI.Toggle(new Rect(10f, 20f, 120f, 20f), CVars.ESP.DrawPlayers, "����");
			CVars.ESP.DrawLoot = GUI.Toggle(new Rect(10f, 40f, 120f, 20f), CVars.ESP.DrawLoot, "����");
			CVars.ESP.DrawRaid = GUI.Toggle(new Rect(10f, 60f, 120f, 20f), CVars.ESP.DrawRaid, "��");
			CVars.ESP.DrawSleepers = GUI.Toggle(new Rect(10f, 80f, 120f, 20f), CVars.ESP.DrawSleepers, "˯��");
			CVars.ESP.DrawAnimals = GUI.Toggle(new Rect(10f, 100f, 120f, 20f), CVars.ESP.DrawAnimals, "����");
			CVars.ESP.DrawResources = GUI.Toggle(new Rect(10f, 120f, 120f, 20f), CVars.ESP.DrawResources, "��Դ");
			GUI.DragWindow(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height));
		}
	}
}
