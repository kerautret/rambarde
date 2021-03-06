﻿using Melodies;
using UniRx;
using UnityEngine;

namespace Bard
{
    [CreateAssetMenu(fileName = "Instrument", menuName = "Instrument")]
    public class Instrument : ScriptableObject {
        
        public Melody[] melodies;
        public string passif;
        public string type;
        public Sprite sprite;
        public Color color;
    }
}
