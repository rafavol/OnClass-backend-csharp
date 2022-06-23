import React, { useState } from 'react'
import {
  OnGoingClass,
  ClassInfo,
  Class,
  RemainingClassTime,
} from './index.style'
import PersonInformationContainer from '../../components/personInformation/index'
import ReactionsContainer from '../../components/reactions'
import VideoContainer from '../../components/video/index'
import SupportMaterialContainer from '../../components/supportMaterial'

interface Props {
  type: string
}

const OnGoingClassContainer: React.FC<Props> = ({ type }) => {
  const [toggleSupportMaterial, setToggleSupportMaterial] = useState(false)

  return (
    <OnGoingClass data-testid='on-going-class-container'>
      <ClassInfo>
        <PersonInformationContainer type={type} />
        <RemainingClassTime data-testid='remaining-class-time'>
          Tempo restante: 57:14
        </RemainingClassTime>
        <ReactionsContainer />
      </ClassInfo>
      <Class>
        <VideoContainer
          setToggleSupportMaterial={setToggleSupportMaterial}
          toggleSupportMaterial={toggleSupportMaterial}
          type={type}
        />
        <SupportMaterialContainer
          type={type}
          toggleSupportMaterial={toggleSupportMaterial}
        />
      </Class>
    </OnGoingClass>
  )
}

export default OnGoingClassContainer