﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GoogleMobileAds.Api;
using System;

public class AdsGoogleMobileBanner : MonoBehaviour {

//	private BannerView bannerView;

	public void Start()
	{
		this.RequestBanner();
	}

	private void RequestBanner()
	{

		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-4378773022879105/8799286961";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-4378773022879105/7812550496";
		#else
		string adUnitId = "unexpected_platform";
		#endif

//		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
//
//		// Called when an ad request has successfully loaded.
//		bannerView.OnAdLoaded += HandleOnAdLoaded;
//		// Called when an ad request failed to load.
//		bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
//		// Called when an ad is clicked.
//		bannerView.OnAdOpening += HandleOnAdOpened;
//		// Called when the user returned from the app after an ad click.
//		bannerView.OnAdClosed += HandleOnAdClosed;
//		// Called when the ad click caused the user to leave the application.
//		bannerView.OnAdLeavingApplication += HandleOnAdLeavingApplication;
//
//		// Create an empty ad request.
//		AdRequest request = new AdRequest.Builder().Build();
//
//		// Load the banner with the request.
//		bannerView.LoadAd(request);
	}

	public void HandleOnAdLoaded(object sender, EventArgs args)
	{
	MonoBehaviour.print("HandleAdLoaded event received");
	}

//	public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
//	{
//	MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
//	+ args.Message);
//	}

	public void HandleOnAdOpened(object sender, EventArgs args)
	{
	MonoBehaviour.print("HandleAdOpened event received");
	}

	public void HandleOnAdClosed(object sender, EventArgs args)
	{
	MonoBehaviour.print("HandleAdClosed event received");
	}

	public void HandleOnAdLeavingApplication(object sender, EventArgs args)
	{
	MonoBehaviour.print("HandleAdLeavingApplication event received");
	}
}


	