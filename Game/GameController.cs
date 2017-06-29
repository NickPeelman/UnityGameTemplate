using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollyBird {

	public class GameController : MonoBehaviour {

		public void Start () {
			
		}

		public void Update () {
			var deltaTime = Time.deltaTime;
		}

		public T SpawnEntity<T>(T entityTemplate) where T : IEntity {
			var clone = Instantiate(entityTemplate) as T;
		}
	}
}

