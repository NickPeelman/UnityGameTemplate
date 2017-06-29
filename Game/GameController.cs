using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollyBird {

	public class GameController : MonoBehaviour {

		public List<IEntity> Entities { get; protected set; }

		public void Start () {
			Entities = new List<IEntity>();
		}

		public void Update () {
			var deltaTime = Time.deltaTime;

			for (int i = 0; i < Entities.Count; i++) {
				Entities[i].OnUpdate(deltaTime);
			}
		}

		public virtual T InstantiateEntity<T>(T template) where T : Entity {
			var clone = Instantiate(template) as T;
			clone.SetGameController(this);
			Entities.Add(clone);
			return clone;
		}
	}
}

