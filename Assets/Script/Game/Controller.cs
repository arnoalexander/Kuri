﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
	public class Controller : Element {

		public GroundController groundController;
		public InputController inputController;
		public PlayerController playerController;
		public ScreenController screenController;
		public EnemyController enemyController;
		public WeaponController weaponController;
		public ObstacleController obstacleController;
		public ScoreController scoreController;
		public CooldownController cooldownController;
		public BackgroundController backgroundController;

	}
}
