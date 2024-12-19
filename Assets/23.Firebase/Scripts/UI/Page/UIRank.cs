using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIRank : UIPage
{
	public Button goBackButton;

	public List<GameObject> rankSlots;
	public List<TextMeshProUGUI> userNameTexts;
	public List<TextMeshProUGUI> levelTexts;

	private List<UserData> userDatas;

	private void Awake()
	{
		goBackButton.onClick.AddListener(GoBackButtonClick);
	}

	private void OnEnable()
	{
		UpdateRank();
	}

	private void GoBackButtonClick()
	{
		UIManager.Instance.PageOpen<UIHome>();
	}

	private void UpdateRank()
	{
		userDatas = FirebaseManager.Instance.GetAllUserData();

		foreach (GameObject rankSlot in rankSlots)
		{
			rankSlot.gameObject.SetActive(false);
		}

		for (int i = 0; i < userDatas.Count; i++)
		{
			rankSlots[i].gameObject.SetActive(true);
			userNameTexts[i].text = userDatas[i].userName;
			levelTexts[i].text = $"Lv. {userDatas[i].level}";
		}
	}
}
