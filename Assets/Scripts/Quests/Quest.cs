using System;


public class Quest : IQuest, IDisposable
{
    private readonly QuestObjectView _view;
    private readonly IQuestModel _model;
    private bool _active;
    public bool IsCompleted { get; private set; }
    public event Action<IQuest> Completed;

    public Quest(QuestObjectView view, IQuestModel model)
    {
        _view = view;
        _model = model;
    }

    private void Complete()
    {
        if (!_active)
            return;

        _active = false;
        IsCompleted = true;
        _view.OnLevelObjectContact -= OnContact;
        _view.ProcessComplete();
        OnCompleted();
    }

    private void OnCompleted()
    {
        Completed?.Invoke(this);
    }

    private void OnContact(CharacterView characterView)
    {
       var completed = _model.TryComplete(characterView.gameObject);
        if (completed)
            Complete();
    }

    public void Reset()
    {
        if (_active)
            return;
        _active = true;
        IsCompleted = false;
        _view.OnLevelObjectContact += OnContact;
        _view.ProcessActivate();
    }

    public void Dispose()
    {
        _view.OnLevelObjectContact -= OnContact;
    }

   
}
