﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVComboExpanded.Interface
{
    public class Changelog
    {
        public static Dictionary<string, string[]> GetChangelog()
        {
            return new Dictionary<string, string[]>()
                {
                    {
                        "v2.0.0.5",
                        [
                            "Fixed a white background which was leaking when an invalid job was automatically picked with the auto-pick setting."
                        ]
                    },
                    {
                        "v2.0.0.4",
                        [
                            "Reworded the Accessiiblity Combos description.",
                            "Fixed SGE's Dyskrasia Psyche Feature's logic.",
                        ]
                    },
                    {
                        "v2.0.0.3",
                        [
                            "WAR's Storm's Path Combo logic fix (electric boogaloo).",
                            "PLD's Divine Might Feature logic fix (also electric boogaloo).",
                            "Added WHM's Glare 4 AoE Feature.",
                            "Added SGE's Dyskrasia Psyche Feature.",
                        ]
                    },
                    {
                        "v2.0.0.2",
                        [
                            "NIN's Auto-Refill Kazematoi additional logic fix.",
                            "WAR's Storm's Path Combo logic fix.",
                            "PLD's Divine Might Feature fix."
                        ]
                    },
                    {
                        "v2.0.0.1", ["NIN's Auto-Refill Kazematoi fix."]
                    },
                    {
                        "v2.0.0.0",
                        ["Initial re-release!",
                        "Every job is Dawntrail updated at least up to the level 90.",
                        "Please request reasonable new features on GitHub (link in the About tab) if you'd like to see new combos.",
                        "A one-time pop-up allows for an easier first installation. It can be re-enabled in the Settings tab.",
                        "Please note that some jobs do not have any combos available at all if you don't enable Expanded combos.",]
                    },
                };
        }
    }
}
