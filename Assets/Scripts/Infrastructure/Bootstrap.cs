using System;
using GameStates.Base;
using GameStates.States;
using UnityEngine;

namespace Infrastructure
{
	public class Bootstrap : MonoBehaviour
	{
		[SerializeField] private GameStateMachineSo _stateMachineSo;

		private void OnEnable()
		{
			_stateMachineSo.Enter<EnterGymStateSo>();
		}
	}
}