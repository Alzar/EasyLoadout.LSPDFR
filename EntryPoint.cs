/*
 *	Developed By: Alzar
 *	Name: Easy Loadout
 *	Dependent: Rage Plugin Hook & LSPDFR
 *	Released On: GitHub & LSPDFR
 */
[assembly: Rage.Attributes.Plugin("Easy Loadout LSPDFR", Author = "sr7066", Description = "Small LSPDFR plugin that triggers loadout give when going on & off duty", SupportUrl = "https://github.com/Alzar/EasyLoadout.LSPDFR/issues")]

namespace EasyLoadoutLSPDFR {
	using LSPD_First_Response.Mod.API;
	using EasyLoadout.Core.Utils;

	public class Main : Plugin {

		public override void Initialize() {
			Functions.OnOnDutyStateChanged += this.DutyStateChange;

			string CurrentVersion = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
			Updater.VersionCheck("LSPDFR", "https://raw.githubusercontent.com/Alzar/EasyLoadout.LSPDFR/master/core-latest.txt", CurrentVersion);
		}

		public void DutyStateChange(bool OnDuty) {
			LoadoutHandler.LSPDFRLoadout(OnDuty);
		}

		public override void Finally() {
		}
	}
}