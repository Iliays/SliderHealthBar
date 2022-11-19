using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
	[SerializeField] private int _health;

	private int _maxHealth;

	public int Health => _health;

	public event UnityAction<int> HealthChanged;

	private void Start()
	{
		_maxHealth = _health;
	}

	public void ApplyDamage(int damage)
	{
		if (_health > 0)
		{
			_health -= damage;
			HealthChanged?.Invoke(_health);
		}
	}

	public void Heal(int health)
	{
		if (_health < _maxHealth)
		{
			_health += health;
			HealthChanged?.Invoke(_health);
		}
	}
}