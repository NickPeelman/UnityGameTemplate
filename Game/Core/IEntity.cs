using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollyBird {

	public interface IEntity {

		GameController GameController { get; }

		void SetGameController (GameController gameController);
		void OnUpdate (float deltaTime);
	}
}

