using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// json���� ������ ���̱� ������ ����ȭ
[Serializable]
public class UserData
{
	public enum UserClass
	{
		Warrior,
		Wizard,
		Rogue,
		Archer
	}

	public string userId { get; set; }
	public string userName;
	public int level;
	public int gold;
	public int exp;
	public UserClass userClass;

	private int[] levelStep = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

	// �⺻ ������
	public UserData() { }

	// ȸ�������� �� ����� ������
	public UserData(string userId)
	{
		this.userId = userId;
		userName = "������ ����";
		level = 1;
		gold = 0;
		exp = 0;
		userClass = UserClass.Warrior;
	}

	public UserData(string userId, string userName, int level, int gold, int exp, UserClass userClass)
	{
		// �α����� �� ����� ������
		this.userId = userId;
		this.userName = userName;
		this.level = level;
		this.gold = gold;
		this.exp = exp;
		this.userClass = userClass;
	}

	// level up
	public void SetLevel()
	{
		for (int i = 0; i < levelStep.Length; i++)
		{
			// exp:0, levelstep[0]:5
			if (exp > levelStep[i]) continue;
			else
			{
				level = i + 1;
				break;
			}
		}
	}
}

// json ��ȯ �� �������� string���� ����Ǳ� ������ �뷮������. �̷��� ���� ���� �ִ�. �ٵ� ����ŷ?������ ���� �� �ʿ��ϴ� ����!
//public class DatabasePacket
//{
//	// username
//	public string aa;
//	// level
//	public int ab;
//}