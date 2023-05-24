using GameStates.Base;
using GameStates.States;
using Sources.Ads;
using StaticContext;
using UnityEngine;

namespace Infrastructure
{
	public class Bootstrap : MonoBehaviour
	{
		[SerializeField] private GameStateMachineFactory _stateMachineFactory;
		[SerializeField] private AdsInitialization _adsInitialization;
		
		private void OnEnable()
		{
			_adsInitialization.Initialize();
			IGameStateMachine stateMachine = _stateMachineFactory.Initialize();

			Instance<IGameStateMachine>.Value = stateMachine;

			stateMachine.Enter<BootstrapState>();
		}
	}
}