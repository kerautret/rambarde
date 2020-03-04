﻿using System.Threading.Tasks;
using Characters;
using Melodies;
using Status;
using UnityEngine;

namespace Music.Melodies {
    [CreateAssetMenu(fileName = "Forte", menuName = "Melody/Forte")]
    class Forte : Melody {
        protected override async Task ExecuteOnTarget(CharacterControl t) {
            await StatusEffect.ApplyBuff(t, 2, BuffType.Attack, 2);
        }
    }
}