using UnityEngine;

namespace Sources.Ads
{
	[CreateAssetMenu(fileName = "AdSettings", menuName = "ScriptableObjects/Ads/Settings")]
	public class AdSettings : ScriptableObject
	{
		public string GameId => _gameId;

		public bool TestMode => _testMode;

		[SerializeField] private string _gameId;
		[SerializeField] private bool _testMode;
		
		
	}
}