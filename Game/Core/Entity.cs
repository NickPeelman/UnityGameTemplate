using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollyBird {

	public class Entity : IEntity {	

		public GameController GameController { get; protected set;}

		public void SetGameController(GameController gameController) {
			this.GameController = gameController;
			this.OnStart();
		}

		public void OnStart() {
			
		}

		public void OnUpdate(float deltaTime) {

		}
	}
}
