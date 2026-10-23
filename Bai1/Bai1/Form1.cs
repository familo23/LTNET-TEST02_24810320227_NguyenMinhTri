using System.ComponentModel;
using System.Globalization;

namespace Bai1
{
    public partial class frmBookingManager : Form
    {
        private readonly BindingList<BookingModel> bookings = new();
        private readonly BindingSource bookingSource = new();
        private ErrorProvider errorProvider = null!;
        private TextBox txtBookingId = null!;
        private TextBox txtCustomerName = null!;
        private TextBox txtIdentityCard = null!;
        private ComboBox cboRoomType = null!;
        private DateTimePicker dtpCheckIn = null!;
        private NumericUpDown numDays = null!;
        private TextBox txtPricePerNight = null!;
        private DataGridView dgvBookings = null!;
        private Button btnAdd = null!;
        private Button btnUpdate = null!;
        private Button btnDelete = null!;
        private Button btnNew = null!;
        private int nextBookingNumber = 1;

        public frmBookingManager()
        {
            InitializeComponent();
            InitializeBookingManager();
        }

        private void InitializeBookingManager()
        {
            Name = "frmBookingManager";
            Text = "Quản lý đặt phòng khách sạn";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(860, 620);
            ClientSize = new Size(1040, 720);
            Font = new Font("Segoe UI", 9F);
            errorProvider = new ErrorProvider(components)
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };

            txtBookingId = new TextBox { Name = "txtBookingId", ReadOnly = true, BackColor = SystemColors.Control };
            txtCustomerName = new TextBox { Name = "txtCustomerName" };
            txtIdentityCard = new TextBox { Name = "txtIdentityCard" };
            cboRoomType = new ComboBox
            {
                Name = "cboRoomType",
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "VIP" });
            dtpCheckIn = new DateTimePicker
            {
                Name = "dtpCheckIn",
                Format = DateTimePickerFormat.Short
            };
            numDays = new NumericUpDown
            {
                Name = "numDays",
                Minimum = 1,
                Maximum = 3650,
                Value = 1
            };
            txtPricePerNight = new TextBox { Name = "txtPricePerNight" };
            dgvBookings = new DataGridView { Name = "dgvBookings" };
            btnAdd = new Button { Name = "btnAdd", Text = "Thêm đặt phòng" };
            btnUpdate = new Button { Name = "btnUpdate", Text = "Cập nhật", Enabled = false };
            btnDelete = new Button { Name = "btnDelete", Text = "Xóa", Enabled = false };
            btnNew = new Button { Name = "btnNew", Text = "Làm mới" };

            ConfigureGrid();
            BuildLayout();

            bookingSource.DataSource = bookings;
            dgvBookings.DataSource = bookingSource;
            dgvBookings.SelectionChanged += DgvBookings_SelectionChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnNew.Click += BtnNew_Click;
            ClearInputFields();
        }

        private void ConfigureGrid()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.ReadOnly = true;
            dgvBookings.MultiSelect = false;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = SystemColors.Window;
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBookingId",
                HeaderText = "Mã Đặt",
                DataPropertyName = nameof(BookingModel.BookingId),
                FillWeight = 75
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCustomerName",
                HeaderText = "Tên Khách",
                DataPropertyName = nameof(BookingModel.CustomerName),
                FillWeight = 130
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdentityCard",
                HeaderText = "CCCD",
                DataPropertyName = nameof(BookingModel.IdentityCard),
                FillWeight = 95
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRoomType",
                HeaderText = "Loại Phòng",
                DataPropertyName = nameof(BookingModel.RoomType),
                FillWeight = 85
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCheckInDate",
                HeaderText = "Ngày Nhận",
                DataPropertyName = nameof(BookingModel.CheckInDate),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                FillWeight = 90
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNumberOfNights",
                HeaderText = "Số Đêm",
                DataPropertyName = nameof(BookingModel.NumberOfNights),
                FillWeight = 65
            });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPricePerNight",
                HeaderText = "Giá/Đêm",
                DataPropertyName = nameof(BookingModel.PricePerNight),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 85
            });
        }

        private void BuildLayout()
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(16)
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 188));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var title = new Label
            {
                Text = "QUẢN LÝ ĐẶT PHÒNG KHÁCH SẠN",
                AutoSize = true,
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.FromArgb(35, 72, 110),
                Margin = new Padding(3, 0, 3, 12)
            };
            layout.Controls.Add(title, 0, 0);

            var inputGroup = new GroupBox
            {
                Text = "Thông tin đặt phòng",
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            var fields = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 4,
                Padding = new Padding(4)
            };
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17));
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            for (var row = 0; row < 4; row++)
            {
                fields.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            }

            AddField(fields, "Mã đặt phòng", txtBookingId, 0, 0);
            AddField(fields, "Tên khách hàng", txtCustomerName, 2, 0);
            AddField(fields, "Số CCCD/CMND", txtIdentityCard, 0, 1);
            AddField(fields, "Loại phòng", cboRoomType, 2, 1);
            AddField(fields, "Ngày nhận phòng", dtpCheckIn, 0, 2);
            AddField(fields, "Số ngày ở", numDays, 2, 2);
            AddField(fields, "Giá phòng/đêm", txtPricePerNight, 0, 3);
            inputGroup.Controls.Add(fields);
            layout.Controls.Add(inputGroup, 0, 1);

            var actions = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0, 10, 0, 10)
            };
            foreach (var button in new[] { btnAdd, btnUpdate, btnDelete, btnNew })
            {
                button.AutoSize = true;
                button.MinimumSize = new Size(115, 34);
                button.Margin = new Padding(0, 0, 8, 0);
                actions.Controls.Add(button);
            }
            btnAdd.BackColor = Color.FromArgb(36, 112, 82);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            layout.Controls.Add(actions, 0, 2);

            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.Margin = new Padding(0);
            layout.Controls.Add(dgvBookings, 0, 3);
            Controls.Add(layout);
        }

        private static void AddField(TableLayoutPanel layout, string labelText, Control input, int labelColumn, int row)
        {
            var label = new Label
            {
                Text = labelText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(4, 3, 4, 3)
            };
            input.Dock = DockStyle.Fill;
            input.Margin = new Padding(4, 5, 10, 5);
            layout.Controls.Add(label, labelColumn, row);
            layout.Controls.Add(input, labelColumn + 1, row);
        }

        private void DgvBookings_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }

            var rowIndex = dgvBookings.SelectedRows[0].Index;
            if (rowIndex >= 0 && rowIndex < bookings.Count)
            {
                bookingSource.Position = rowIndex;
                DisplayBooking(bookings[rowIndex]);
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void DisplayBooking(BookingModel booking)
        {
            txtBookingId.Text = booking.BookingId;
            txtCustomerName.Text = booking.CustomerName;
            txtIdentityCard.Text = booking.IdentityCard;
            cboRoomType.SelectedItem = booking.RoomType;
            dtpCheckIn.Value = booking.CheckInDate;
            numDays.Value = Math.Clamp(booking.NumberOfNights, (int)numDays.Minimum, (int)numDays.Maximum);
            txtPricePerNight.Text = booking.PricePerNight.ToString(CultureInfo.CurrentCulture);
            ClearValidationErrors();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!TryReadInput(out var customerName, out var identityCard, out var roomType, out var pricePerNight))
            {
                return;
            }

            var booking = new BookingModel
            {
                BookingId = $"BK{nextBookingNumber:D3}",
                CustomerName = customerName,
                IdentityCard = identityCard,
                RoomType = roomType,
                CheckInDate = dtpCheckIn.Value.Date,
                NumberOfNights = decimal.ToInt32(numDays.Value),
                PricePerNight = pricePerNight
            };
            nextBookingNumber++;
            bookings.Add(booking);
            bookingSource.Position = bookings.Count - 1;
            dgvBookings.ClearSelection();
            dgvBookings.Rows[bookings.Count - 1].Selected = true;
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            var booking = GetSelectedBooking();
            if (booking is null || !TryReadInput(out var customerName, out var identityCard, out var roomType, out var pricePerNight))
            {
                return;
            }

            booking.CustomerName = customerName;
            booking.IdentityCard = identityCard;
            booking.RoomType = roomType;
            booking.CheckInDate = dtpCheckIn.Value.Date;
            booking.NumberOfNights = decimal.ToInt32(numDays.Value);
            booking.PricePerNight = pricePerNight;
            bookingSource.ResetCurrentItem();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var booking = GetSelectedBooking();
            if (booking is null)
            {
                return;
            }

            var result = MessageBox.Show(
                this,
                $"Bạn có chắc chắn muốn xóa đặt phòng {booking.BookingId} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            bookings.Remove(booking);
            BtnNew_Click(sender, e);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            dgvBookings.ClearSelection();
            dgvBookings.CurrentCell = null;
            ClearInputFields();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private BookingModel? GetSelectedBooking()
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                return null;
            }

            var index = dgvBookings.SelectedRows[0].Index;
            return index >= 0 && index < bookings.Count ? bookings[index] : null;
        }

        private bool TryReadInput(out string customerName, out string identityCard, out string roomType, out decimal pricePerNight)
        {
            customerName = txtCustomerName.Text.Trim();
            identityCard = txtIdentityCard.Text.Trim();
            roomType = cboRoomType.SelectedItem?.ToString() ?? string.Empty;
            pricePerNight = 0;
            ClearValidationErrors();
            var isValid = true;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                errorProvider.SetError(txtCustomerName, "Vui lòng nhập tên khách hàng.");
                isValid = false;
            }

            if (identityCard.Length is not (9 or 12) || identityCard.Any(character => character < '0' || character > '9'))
            {
                errorProvider.SetError(txtIdentityCard, "CCCD/CMND phải gồm đúng 9 hoặc 12 chữ số.");
                isValid = false;
            }

            if (!decimal.TryParse(txtPricePerNight.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out pricePerNight) || pricePerNight <= 0)
            {
                errorProvider.SetError(txtPricePerNight, "Giá phòng phải là số lớn hơn 0.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(roomType))
            {
                errorProvider.SetError(cboRoomType, "Vui lòng chọn loại phòng.");
                isValid = false;
            }

            return isValid;
        }

        private void ClearInputFields()
        {
            txtBookingId.Text = $"BK{nextBookingNumber:D3}";
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            cboRoomType.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Today;
            numDays.Value = 1;
            txtPricePerNight.Clear();
            ClearValidationErrors();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ClearValidationErrors()
        {
            errorProvider.SetError(txtCustomerName, string.Empty);
            errorProvider.SetError(txtIdentityCard, string.Empty);
            errorProvider.SetError(txtPricePerNight, string.Empty);
            errorProvider.SetError(cboRoomType, string.Empty);
        }
    }
}
