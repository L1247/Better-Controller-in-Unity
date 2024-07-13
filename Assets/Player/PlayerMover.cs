#region

using UnityEngine;

#endregion

namespace Player
{
    public class PlayerMover : MonoBehaviour
    {
    #region Private Variables

        public  Vector2   Position => transform.position;

        [SerializeField]
        private float moveSpeed = 3f;

        
    #endregion

    #region Public Methods

        public void Move(Vector2 movement)
        {
            transform.position += (Vector3)movement * moveSpeed;
        }

    #endregion
    }
}