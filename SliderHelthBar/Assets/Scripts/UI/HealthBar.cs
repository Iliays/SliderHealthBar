using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
	[SerializeField] private Player _player;
	[SerializeField] private Slider _healthBar;
	[SerializeField] private int _changeSpeed;

	private void OnEnable()
	{
		_player.HealthChanged += OnHealthChanged;
	}

	private void OnDisable()
	{
		_player.HealthChanged -= OnHealthChanged;
	}

	private void Start()
	{
		_healthBar.value = _player.Health;
	}

	private void OnHealthChanged(int health)
	{
		_healthBar.DOValue(health, _changeSpeed);
	}
}