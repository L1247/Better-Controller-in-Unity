#region

using TMPro;
using UnityEngine;

#endregion

namespace Player
{
    public class PlayerMoveView
    {
    #region Private Variables

        private readonly TMP_Text positionText;

    #endregion

    #region Constructor

        public PlayerMoveView(TMP_Text positionText)
        {
            this.positionText = positionText;
        }

    #endregion

    #region Public Methods

        public void UpdatePosition(Vector2 position)
        {
            positionText.text = position.ToString();
        }

    #endregion
    }
}