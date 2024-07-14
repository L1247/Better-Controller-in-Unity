#region

using UnityEngine;

#endregion

namespace Player
{
    public class PlayerController
    {
    #region Private Variables

        private          PlayerMover    mover;
        private readonly PlayerMoveView moveView;
        private readonly GameObject     playerPrefab;
        private          bool           playerExist;

    #endregion

    #region Constructor

        public PlayerController(PlayerMoveView moveView , GameObject playerPrefab)
        {
            this.playerPrefab = playerPrefab;
            this.moveView     = moveView;
        }

    #endregion

    #region Public Methods

        public void CreatePlayer(Vector2 spawnPosition , float moveSpeed)
        {
            if (playerExist) return;
            playerExist = true;
            var playerInstance  = Object.Instantiate(playerPrefab , spawnPosition , Quaternion.identity);
            var playerTransform = playerInstance.transform;
            mover = new PlayerMover(moveSpeed , playerTransform);
        }

        public void MovePlayerCharacter(Vector2 movement)
        {
            if (playerExist == false) return;
            mover.Move(movement);
            moveView.UpdatePosition(mover.Position);
        }

    #endregion
    }
}