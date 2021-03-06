﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Linq;
using osu.Game.Beatmaps;
using osu.Game.Rulesets;
using osu.Game.Screens.Play;

namespace osu.Game.Tests.Visual
{
    public class TestCaseReplay : TestCasePlayer
    {
        protected override Player CreatePlayer(WorkingBeatmap beatmap, Ruleset ruleset)
        {
            beatmap.Mods.Value = beatmap.Mods.Value.Concat(new[] { ruleset.GetAutoplayMod() });
            return base.CreatePlayer(beatmap, ruleset);
        }
    }
}
