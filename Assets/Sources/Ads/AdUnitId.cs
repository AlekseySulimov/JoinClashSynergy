using UnityEngine;

namespace Sources.Ads
{
	[CreateAssetMenu(fileName = "AdUnitId", menuName = "ScriptableObject/Ads/Ids" )]
	public class AdUnitId : ScriptableObject
	{
		[SerializeField] private string _banner;
		[SerializeField] private string _interstitial;
		[SerializeField] private string _rewarded;

		public string Banner => _banner;

		public string Interstitial => _interstitial;

		public string Rewarded => _rewarded;
	}
}