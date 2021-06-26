using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAds : MonoBehaviour
{

    string gameId = "4191410";
    string mySurfacingId = "IntestitialAd";
    bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady())
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show(mySurfacingId, options);
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
 
    private void HandleShowResult(ShowResult result)
    {
        FindObjectOfType<SceneController>().ChangeScene("MenuScene");
    }
}
