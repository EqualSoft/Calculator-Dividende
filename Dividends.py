dicountinued

def calculate_tax():
    gross = float(gross_entry.get())
    tax_percentage = float(tax_entry.get())
    tax = (gross * tax_percentage) / 100
    net = gross - tax
    net_label.config(text=f'Net amount: {net}')

def calculate_gross():
    net = float(net_entry.get())
    tax_percentage = float(tax_entry_2.get())
    tax = (net * tax_percentage) / (100 - tax_percentage)
    gross = net + tax
    gross_label_2.config(text=f'Gross amount: {net}')

root = tk.Tk()
root.title("Dividends Tax Calculator")
root.geometry("550x350") #set window size
ttk.Style().theme_use("clam") #set theme

frame_1 = ttk.Frame(root)
frame_1.pack(side=tk.LEFT)

frame_2 = ttk.Frame(root)
frame_2.pack(side=tk.RIGHT)

gross_label = ttk.Label(frame_1, text="Enter the gross amount: ")
gross_label.pack()

gross_entry = ttk.Entry(frame_1)
gross_entry.pack()

tax_label = ttk.Label(frame_1, text="Enter the tax percentage: ")
tax_label.pack()

tax_entry = ttk.Entry(frame_1, textvariable=tk.StringVar(value='8'))
tax_entry.pack()

calculate_button = ttk.Button(frame_1, text="Calculate", command=calculate_tax)
calculate_button.pack()

net_label = ttk.Label(frame_1)
net_label.pack()

net_label_2 = ttk.Label(frame_2, text="Enter the net amount: ")
net_label_2.pack()

net_entry = ttk.Entry(frame_2)
net_entry.pack()

tax_label_2 = ttk.Label(frame_2, text="Enter the tax percentage: ")
tax_label_2.pack()

tax_entry_2 = ttk.Entry(frame_2, textvariable=tk.StringVar(value='8'))
tax_entry_2.pack()

calculate_button_2 = ttk.Button(frame_2, text="Calculate", command=calculate_gross)
calculate_button_2.pack()

gross_label_2 = ttk.Label(frame_2)
gross_label_2.pack()

root.mainloop()
