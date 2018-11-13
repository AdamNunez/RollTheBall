using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class MovementController
    {
        public MovementController()
        {

        }

        public Vector3 MoveByAxis()
        {
            float vert = Input.GetAxis("Vertical");
            float hor = Input.GetAxis("Horizontal");
            Vector3 move = new Vector3()
            {
                x = hor,
                y = 0,
                z = vert
            };
            return move;
        }
    }
}
