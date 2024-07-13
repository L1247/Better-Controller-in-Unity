#region

using TMPro;
using UnityEngine;

#endregion

namespace Player
{
    public class PlayerMoveView : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private TMP_Text positionText;

    #endregion

    #region Unity events

        public void UpdatePosition(Vector2 position)
        {
            positionText.text = position.ToString();
        }

    #endregion
    }
}