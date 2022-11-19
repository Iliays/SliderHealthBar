using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

	private int _maxHealth;

	public int Health => _health;

	private void Start()
	{
		_maxHealth = _health;
	}

	public void ApplyDamage(int damage)
	{
		if (_health > 0)
		{
			_health -= damage;
		}
	}

    public void Heal(int health)
	{
		if (_health < _maxHealth)
		{
			_health += health;
		}
	}
}
