using UnityEngine;

public class SimplePatrolAI 
{
    private readonly EnemyView _view;
    private readonly SimplePatrolAIModel _model;

    public SimplePatrolAI(EnemyView view, SimplePatrolAIModel model)
    {
        _view = view;
        _model = model;
    }

    public void FixedUpdate(Transform playerTransform)
    {
        _view.Rigidbody.velocity = _model.CalculateVelocity(_view.transform.position) * Time.fixedDeltaTime;
        _model.ChoosePathfindinfMethod(_view, playerTransform);
       
    }
}
