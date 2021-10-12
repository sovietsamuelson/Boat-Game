﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace boatgame
{
    class GameObject
    {
        public GameObject(Vector2 coord, float angle)
        {
            posCoord = coord;
            posAngle = angle;
        }

        public virtual void Update(float deltaSeconds)
        {
            
        }

        public Vector2 posCoord;

        public Texture2D texture;

        public float posAngle;


    }
}