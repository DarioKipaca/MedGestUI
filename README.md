<h1> UI MODERNO MEDGEST C# WINFORMS</h1>

<p>Layout moderno desenvolvido utilizando C# WinForms Application para desafiar o preconceito de que WinForms não é capaz de criar designs bonitos, no estilo da web. Este projeto prova que é possível alcançar layouts atrativos e funcionais, mesmo dentro do ambiente tradicional do Windows Forms. Vamos quebrar esses estereótipos juntos!</p>

<br>
<img src="https://github.com/DarioKipaca/MedGestUI/assets/157759202/8ba5a274-d432-4f2e-a19e-3134b55ffeea.gif"/>
<br>

<code>
// Codigo para alternar de checks no botões do menu

      public void Buttonchecked(object? sender, EventArgs e)
      {
          Guna2Button buttonClicked = (Guna2Button)sender;

          if (buttonClicked == null || buttonClicked.Name == _ButtonStart.Name)
              return;

          _ButtonStart.Checked = false;
          _ButtonStart.Tag = false;
          buttonClicked.Checked = true;
          buttonClicked.Tag = true;
          _ButtonStart =buttonClicked;
      }
</code>


<br>

<code>
// Codigo para abrir um formulário em um painel

        private void Openforminconteiner(Form formforopen)
        {
            if (_PanelConteiner.Controls.Count > 0)
            {
                Form Temp = (Form)_PanelConteiner.Controls[0];
                Temp.Close();
            }

            formforopen.TopLevel = false;
            formforopen.FormBorderStyle = FormBorderStyle.None;
            formforopen.Dock = DockStyle.Fill;
            _PanelConteiner.Controls.Add(formforopen);
            formforopen.Show();
        }
</code>

