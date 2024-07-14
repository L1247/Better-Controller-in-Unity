#region

using UnityEngine;

#endregion

namespace Player
{
    public class PlayerMover
    {
    #region Public Variables

        public Vector2 Position => transform.position;

    #endregion

    #region Private Variables

        private readonly float moveSpeed;

        private readonly Transform transform;

    #endregion

    #region Constructor

        public PlayerMover(float moveSpeed , Transform transform)
        {
            this.transform = transform;
            this.moveSpeed = moveSpeed;
        }

    #endregion

    #region Public Methods

        public void Move(Vector2 movement)
        {
            transform.position += (Vector3)movement * moveSpeed;
        }

    #endregion
    }
}