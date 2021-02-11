//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.Ur3Moveit
{
    public class MoverServiceRequest : Message
    {
        public const string RosMessageName = "ur3_moveit/MoverService";

        public UR3MoveitJoints joints_input;
        public Geometry.Pose pick_pose;
        public Geometry.Pose place_pose;

        public MoverServiceRequest()
        {
            this.joints_input = new UR3MoveitJoints();
            this.pick_pose = new Geometry.Pose();
            this.place_pose = new Geometry.Pose();
        }

        public MoverServiceRequest(UR3MoveitJoints joints_input, Geometry.Pose pick_pose, Geometry.Pose place_pose)
        {
            this.joints_input = joints_input;
            this.pick_pose = pick_pose;
            this.place_pose = place_pose;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(joints_input.SerializationStatements());
            listOfSerializations.AddRange(pick_pose.SerializationStatements());
            listOfSerializations.AddRange(place_pose.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.joints_input.Deserialize(data, offset);
            offset = this.pick_pose.Deserialize(data, offset);
            offset = this.place_pose.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "MoverServiceRequest: " +
            "\njoints_input: " + joints_input.ToString() +
            "\npick_pose: " + pick_pose.ToString() +
            "\nplace_pose: " + place_pose.ToString();
        }
    }
}