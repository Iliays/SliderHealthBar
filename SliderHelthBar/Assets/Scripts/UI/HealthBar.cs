using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	[SerializeField] private Player _player;
	[SerializeField] private Slider _healthBar;
	[SerializeField] private int _changeSpeed;

	private void Start()
	{
		_healthBar.value = _player.Health;
	}

	private void Update()
	{
		_healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, _changeSpeed * Time.deltaTime);
	}
}
