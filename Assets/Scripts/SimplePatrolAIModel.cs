using UnityEngine;

public class SimplePatrolAIModel 
{
    private readonly AIConfig _config;
    private Transform _target;
    private int _currentPointIndex;
    

    public SimplePatrolAIModel(AIConfig config)
    {
        _config = config;
        _target = GetNextWaypoint();
        
    }

    private Transform GetNextWaypoint()
    {
        _currentPointIndex = (_currentPointIndex + 1) % _config.Waypoints.Length;
        return _config.Waypoints[_currentPointIndex];
    }

    public Vector2 CalculateVelocity(Vector2 fromPosition)
    {
        var distance = Vector2.Distance(_target.position, fromPosition);

        if (distance < _config.MinDistanceToTarget)
            _target = GetNextWaypoint();

        var direction = ((Vector2)_target.position - fromPosition).normalized;

        return _config.Speed * direction;
    }

    public void ChoosePathfindinfMethod(EnemyView enemyView, Transform playerTransform)
    {
        float distance = (enemyView.transform.position - playerTransform.position).magnitude;
        if(distance < _config.MinDistanceToPlayer)
        {
            enemyView.AIPath.enabled = true;
        }
        else
        {
            enemyView.AIPath.enabled = false;
        }
    }

}
