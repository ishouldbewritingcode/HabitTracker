import { useState } from "react";
import { Button } from "./Button";
import { useHabits } from "../context/useHabits";

export default function HabitForm() {
	const [name, setName] = useState("");
	const { addHabit } = useHabits();

	function handleSubmit(e: React.FormEvent<HTMLFormElement>) {
		e.preventDefault();
		if (name.trim() === "") return;
		setName("");
		addHabit(name.trim());
		console.log("Add Habit:", name);
	}

	return (
		<form className="flex gap-2" onSubmit={handleSubmit}>
			<input
				type="text"
				id="habit-name"
				value={name}
				onChange={(e) => setName(e.target.value)}
				className="flex-1 bg-zinc-800 px-4 py-2 outline-none focus-visible:ring-2 focus-visible:ring-violet-500 rounded-lg"
				placeholder="New Habit..."
			/>
			<Button
				disabled={name.trim() === ""}
				className="rounded-lg px-4 py-3 font-medium"
			>
				Add Habit
			</Button>
		</form>
	);
}
